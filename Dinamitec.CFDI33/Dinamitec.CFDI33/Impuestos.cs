using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dinamitec.CFDI33
{
    public class Impuestos
    {
        [XmlAttribute]
        public string TotalImpuestosTrasladados { get; set; }
        [XmlArray("Traslados"), XmlArrayItem("Traslado")]
        public Traslado[] Traslado { get; set; }
        [XmlArray("Retenciones"), XmlArrayItem("Retencion")]
        public Retencion[] Retencion { get; set; }
    }
}
