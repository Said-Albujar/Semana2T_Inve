    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inverntario_Semana2
{
    public abstract class ArmaBase
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int Daño { get; set; }
        public double VelocidadAtaque { get; set; }
        public Flecha flechas { get; internal set; }
        public Bala balas { get; internal set; }


        public double CalcularDañoPorSegundo()
        {
            return Daño * VelocidadAtaque;
        }
    }
}
