using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dinamitec.CFDI33
{
    public class Pago
    {
        [XmlAttribute]
        public string FechaPago { get; set; }
        [XmlAttribute]
        public string FormaDePagoP { get; set; }
        [XmlAttribute]
        public string MonedaP { get; set; }
        [XmlAttribute]
        public string Monto { get; set; }
        [XmlAttribute]
        public string RfcEmisorCtaOrd { get; set; }
        [XmlAttribute]
        public string CtaOrdenante { get; set; }
        [XmlAttribute]
        public string RfcEmisorCtaBen { get; set; }
        [XmlAttribute]
        public string CtaBeneficiario { get; set; }

        //[XmlArrayItem("DoctoRelacionado")]
        [XmlElement("DoctoRelacionado")]
        public List<DoctoRelacionado> DoctoRelacionado { get; set; }
    }

    public class Pagos
    {
        [XmlArray("Pagos"), XmlArrayItem("Pago")]
        public Pago[] Pago;
    }
}
