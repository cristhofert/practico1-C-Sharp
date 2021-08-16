using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared
{
   

    public class Persona
    {
        public String Nombre { get; set; }
        public String Apellido { get; set; }

        private string documento = "";
        public String Documento {
            get { return documento; }
            set {
                if (value is null || value.Length > 7)
                    throw new Exception("Formato de documento incorrecto");
                else
                    documento = value.ToUpper();
            }
        }
        public DateTime? FechaNacimiento { get; set; }
    }
}
