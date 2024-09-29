using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega.FE
{
    public class Contacto
    {
        public string nombre {  get; set; }
        public string telefono { get; set; }

        public override string ToString()
        {
            return nombre.ToUpper() + "-" + telefono;
        }

        


    }
}
