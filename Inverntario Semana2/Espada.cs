using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inverntario_Semana2
{
    public class Espada : ArmaBase, IArmaCuerpoACuerpo
    {
        public Espada()
        {
            Nombre = "Espada";
            Daño = 30;
            VelocidadAtaque = 25;
        }
    }
}
