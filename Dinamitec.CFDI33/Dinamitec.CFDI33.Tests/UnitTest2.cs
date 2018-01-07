using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dinamitec.CFDI33.Tests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void TestMethod1()
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-ddTHH:mm::ss");

            //Complemento de pago

            Comprobante comprobante = new Comprobante {
                Version = "3.3",
                Folio = "TEST-00001",
                Fecha = fecha,
                Serie = "SC",
                Moneda = "MXN",
                TipoDeComprobante = "P",
                LugarExpedicion = "03100",
                NoCertificado = "00001000000000000000",
                FormaPago = "03",
                MetodoPago = "PUE",
                SubTotal = 0,
                Total = 0,
                Emisor = new Emisor
                {
                    Rfc = "rfc emisor",
                    Nombre = "Nombre del emisor",
                    RegimenFiscal = "601"
                },
                Receptor = new Receptor
                {
                    Rfc = "rfc receptor",
                    Nombre = "Nombre del receptor",
                    UsoCFDI = "P01"
                },
                Conceptos = new Concepto[]
                {
                    new Concepto
                    {
                        ClaveProdServ="84111506",
                        Cantidad="1",
                        ClaveUnidad="ACT",
                        Descripcion="Pago",
                        ValorUnitario= "0.00",
                        Importe ="0.00"
                    }
                },
                Complemento = new Complemento {
                    Pagos = new Pagos()
                }
            };

            //Agregar pagos
            List<Pago> lista = new List<Pago>();
            lista.Add(new Pago
            {
                FechaPago = fecha,
                FormaDePagoP = "03",
                MonedaP = "MXN",
                Monto = "10000",
                RfcEmisorCtaOrd = "CPV810615PP5",
                CtaOrdenante = "9876543210",
                RfcEmisorCtaBen = "BNM840515VB1",
                CtaBeneficiario = "1234567890",
                DoctoRelacionado = new List<DoctoRelacionado> { new DoctoRelacionado{
                                        IdDocumento="8f8d900a-899a-4763-a17e-56fd9e6ebe97", //
                                        MonedaDR="MXN",
                                        MetodoDePagoDR="PPD",
                                        NumParcialidad="1",
                                        ImpSaldoAnt ="10000",
                                        ImpPagado="5000",
                                        ImpSaldoInsoluto = "5000"
                                    },
                                    new DoctoRelacionado{
                                        IdDocumento="8f8d900a-899a-4763-a17e-56fd9e6ebe97", //
                                        MonedaDR="MXN",
                                        MetodoDePagoDR="PPD",
                                        NumParcialidad="2",
                                        ImpSaldoAnt ="10000",
                                        ImpPagado="5000",
                                        ImpSaldoInsoluto = "5000"
                                    }
                }
            });
            comprobante.Complemento.Pagos.Pago = lista;

            //Serialize

            StringBuilder sb = new StringBuilder();
            MemoryStream ms = new MemoryStream();

            XmlSerializer xs = new XmlSerializer(typeof(Comprobante));
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
            ns.Add("cfdi", "http://www.sat.gob.mx/cfd/3");
            ns.Add("pago10", "http://www.sat.gob.mx/Pagos");

            xs.Serialize(ms, comprobante, ns);

            ms.Position = 0;
            using (StreamReader reader = new StreamReader(ms))
            {
                sb.Append(reader.ReadToEnd());
            }

            string result = sb.ToString();

        }
    }
}
