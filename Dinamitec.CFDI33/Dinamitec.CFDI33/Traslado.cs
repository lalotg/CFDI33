using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dinamitec.CFDI33
{
    public class Traslado
    {
        [XmlAttribute]
        public string Base { get; set; }
        [XmlAttribute]
        public string Impuesto { get; set; }
        [XmlAttribute]
        public string TipoFactor { get; set; }
        [XmlAttribute]
        public string TasaOCuota { get; set; }
        [XmlAttribute]
        public double Importe { get; set; }
    }
}
