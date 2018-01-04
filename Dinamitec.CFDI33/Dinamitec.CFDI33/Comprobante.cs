using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dinamitec.CFDI33
{
    [XmlRoot("Comprobante", Namespace = "http://www.sat.gob.mx/cfd/3")]
    public class Comprobante
    {
        [XmlAttribute]
        public string Version { get; set; }
        [XmlAttribute]
        public string Serie { get; set; }
        [XmlAttribute]
        public string Folio { get; set; }
        [XmlAttribute]
        public string Fecha { get; set; }
        [XmlAttribute]
        public double SubTotal { get; set; }
        [XmlAttribute]
        public double Total { get; set; }
        [XmlAttribute]
        public string Moneda { get; set; }
        [XmlAttribute]
        public string TipoDeComprobante { get; set; }
        [XmlAttribute]
        public string FormaPago { get; set; }
        [XmlAttribute]
        public string MetodoPago { get; set; }
        [XmlAttribute]
        public string CondicionesDePago { get; set; }
        [XmlAttribute]
        public string Descuento { get; set; }
        [XmlAttribute]
        public string TipoCambio { get; set; }
        [XmlAttribute]
        public string LugarExpedicion { get; set; }
        [XmlAttribute]
        public string Confirmacion { get; set; }
        [XmlAttribute]
        public string NoCertificado { get; set; }
        [XmlAttribute]
        public string Certificado { get; set; }
        [XmlAttribute]
        public string Sello { get; set; }

        [XmlElement]
        public Emisor Emisor { get; set; }
        [XmlElement]
        public Receptor Receptor { get; set; }

        [XmlElement]
        public Impuestos Impuestos { get; set; }
    }
}
