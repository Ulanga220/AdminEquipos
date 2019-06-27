using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminEquipos
{
    class Sensor
    {
        public string id { get; set; }
        public string locacion { get; set; }
        public string equipo { get; set; }

        public bool ValidarId (string id)
        {
            int numero;

            foreach (char x in id)
            {
                if (Int32.TryParse(x.ToString(), out numero))
                {
                     return false;
                }
                   
            }
            if(id.Length == 4)
            {
                return true;
            }

            return false;

            
        }
                   

    }
}
