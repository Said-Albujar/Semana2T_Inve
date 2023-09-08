using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inverntario_Semana2
{
    public class Pistola : ArmaBase, IArmaDistancia
    {
        public IProyectil Proyectil { get; set; }

        public Pistola()
        {
            Nombre = "Pistola";
            Daño = 25;
            VelocidadAtaque = 10;
        }

        public double CalcularDanioPorSegundo()
        {
            return Daño * VelocidadAtaque + Proyectil.Daño;
        }
    }
}
