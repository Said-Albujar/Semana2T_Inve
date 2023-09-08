using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inverntario_Semana2
{
    public class SistemaInventario
    {
        private List<ArmaBase> inventario;

        public SistemaInventario()
        {
            inventario = new List<ArmaBase>();
        }
            
        public void AgregarArma(ArmaBase arma)
        {
            inventario.Add(arma);
        }

        public void MostrarInventario()
        {
            Console.WriteLine("Inventario de armas:");
            foreach (var arma in inventario)
            {
                Console.WriteLine($"{arma.Nombre} - Daño: {arma.Daño} - Velocidad de ataque {arma.VelocidadAtaque} - Daño por segundo: {arma.CalcularDañoPorSegundo()}");
            }
        }

        public void EliminarArma(ArmaBase arma)
        {
            inventario.Remove(arma);
        }
    }
}
