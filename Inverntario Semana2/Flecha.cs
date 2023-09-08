using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inverntario_Semana2
{
    public class Flecha : IProyectil
    {
        public string Nombre { get; set; }
        public int Daño { get; set; }

        public Flecha()
        {
            Nombre = "Flecha";
            Daño = 10;
        }
    }
}
