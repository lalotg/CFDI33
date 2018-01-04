using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dinamitec.CFDI33
{
    public class Concepto
    {
        [XmlAttribute]
        public string ClaveProdServ { get; set; }
        [XmlAttribute]
        public string Cantidad { get; set; }
        [XmlAttribute]
        public string Unidad { get; set; }
        [XmlAttribute]
        public string ClaveUnidad { get; set; }
        [XmlAttribute]
        public string Descripcion { get; set; }
        [XmlAttribute]
        public string ValorUnitario { get; set; }
        [XmlAttribute]
        public string Importe { get; set; }
        [XmlAttribute]
        public string NoIdentificacion { get; set; }
        [XmlElement]
        public Impuestos Impuestos { get; set; }
    }
}
