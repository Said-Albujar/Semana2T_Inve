using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inverntario_Semana2
{
    public class Bala : IProyectil
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int Daño { get; set; }

        public Bala()
        {
            Nombre = "Bala";
            Precio = 50;
            Daño = 20;
        }
    }
}
