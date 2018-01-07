using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dinamitec.CFDI33
{
    public class Complemento
    {
        [XmlElement(Namespace = "http://www.sat.gob.mx/Pagos")]
        public Pagos Pagos { get; set; }
    }
}
