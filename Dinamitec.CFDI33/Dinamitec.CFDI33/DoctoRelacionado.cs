using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dinamitec.CFDI33
{
    public class DoctoRelacionado
    {
        [XmlAttribute]
        public string IdDocumento { get; set; }
        [XmlAttribute]
        public string MonedaDR { get; set; }
        [XmlAttribute]
        public string TipoCambioDR { get; set; }
        [XmlAttribute]
        public string MetodoDePagoDR { get; set; }
        [XmlAttribute]
        public string NumParcialidad { get; set; }
        [XmlAttribute]
        public string ImpSaldoAnt { get; set; }
        [XmlAttribute]
        public string ImpPagado { get; set; }
        [XmlAttribute]
        public string ImpSaldoInsoluto { get; set; }
    }
}
