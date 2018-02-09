using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dinamitec.CFDI33
{
    public class Generador
    {
        private Comprobante Comprobante;
        StringBuilder sb;
        MemoryStream ms;
        XmlSerializer xs;
        XmlSerializerNamespaces ns;

        public Generador(Comprobante comprobante)
        {
            this.Comprobante = comprobante;
            sb = new StringBuilder();
            ms = new MemoryStream();
            xs = new XmlSerializer(typeof(Comprobante));
            ns = new XmlSerializerNamespaces();
            ns.Add("cfdi", "http://www.sat.gob.mx/cfd/3");

        }

        public string SerializeComprobante()
        {
            return Crear();
        }

        public string SerializePago()
        {
            ns.Add("pago10", "http://www.sat.gob.mx/Pagos");

            return Crear();
        }

        string Crear()
        {
            string result = "";
            xs.Serialize(ms, Comprobante, ns);

            ms.Position = 0;
            using (StreamReader reader = new StreamReader(ms))
            {
                sb.Append(reader.ReadToEnd());
            }

            return result = sb.ToString();
        }
    }
}
