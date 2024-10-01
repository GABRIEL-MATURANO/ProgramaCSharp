using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega.FE
{
    public class Contacto
    {
        public string nombre { get; set; }
        public string telefono { get; set; }

        public override string ToString()
        {
            return nombre.ToUpper() + "-" + telefono;
        }

        public Contacto(string nombre, string telefono)
        {

            this.nombre = nombre;
            this.telefono = telefono;
        }

        public Contacto()
        {

        }
    }
}
