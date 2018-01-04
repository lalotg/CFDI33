using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dinamitec.CFDI33
{
    public class Receptor
    {
        [XmlAttribute]
        public string Rfc { get; set; }
        [XmlAttribute]
        public string Nombre { get; set; }
        [XmlAttribute]
        public string UsoCFDI { get; set; }
    }
}
