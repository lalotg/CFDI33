using System;
using System.IO;
using System.Text;
using System.Xml.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Dinamitec.CFDI33.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-ddTHH:mm::ss");

            //Generar Comprobante
            Comprobante comprobante = new Comprobante
            {
                Version = "3.3",
                Folio = "TEST-00001",
                Fecha = fecha,
                Serie ="SC",
                Moneda = "MXN",
                TipoDeComprobante = "I",
                LugarExpedicion = "03100",
                NoCertificado = "00001000000000000000",
                FormaPago = "03",
                MetodoPago = "PUE",
                SubTotal = 10000,
                Total = 11600,
                Emisor = new Emisor
                {
                    Rfc="rfc emisor",
                    Nombre = "Nombre del emisor",
                    RegimenFiscal ="601"
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
                        Descripcion="Articulo n",
                        ValorUnitario= "10000",
                        Importe ="10000",
                        Impuestos = new Impuestos
                        {
                            Traslado = new Traslado[]
                            {
                                new Traslado
                                {
                                    Importe = 1600,
                                    Base = "10000",
                                    TipoFactor = "Tasa",
                                    TasaOCuota = "0.160000",
                                    Impuesto = "002"
                                }
                            }
                        }
                    }
                },
                Impuestos = new Impuestos
                {
                    TotalImpuestosTrasladados = "1600",
                    Traslado = new Traslado[]
                    {
                        new Traslado
                        {
                            Importe = 1600,
                            Impuesto="002",
                            TipoFactor = "Tasa",
                            TasaOCuota = "0.160000"
                        }
                    }
                }
            };

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
