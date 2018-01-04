using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dinamitec.CFDI33
{
    public class Retencion
    {
        public double Base { get; set; }
        public string Impuesto { get; set; }
        public string TipoFactor { get; set; }
        public double TasaOCuota { get; set; }
        public double Importe { get; set; }
    }
}
