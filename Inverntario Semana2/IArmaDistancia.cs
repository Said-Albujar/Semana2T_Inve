using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inverntario_Semana2
{
    public interface IArmaDistancia
    {
        string Nombre { get; }
        int Daño { get; }
        double VelocidadAtaque { get; }
        IProyectil Proyectil { get; }
        double CalcularDañoPorSegundo();
    }
}
