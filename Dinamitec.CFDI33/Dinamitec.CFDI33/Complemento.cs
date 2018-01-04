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
        [XmlArray("Pagos"), XmlArrayItem("Pago")]
        public Pago[] Pago { get; set; }
    }
}
