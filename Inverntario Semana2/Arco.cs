using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inverntario_Semana2
{
    public class Arco : ArmaBase, IArmaDistancia
    {
        public IProyectil Proyectil { get; set; }

        public Arco()
        {
            Nombre = "Arco";
            Daño = 15;
            VelocidadAtaque = 15;
        }

        public double CalcularDanioPorSegundo()
        {
            return Daño * VelocidadAtaque + Proyectil.Daño;
        }
    }
}
