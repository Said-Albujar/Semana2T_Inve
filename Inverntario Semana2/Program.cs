using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inverntario_Semana2
{
    class Program
    {
        static void Main()
        {
            SistemaInventario inventario = new SistemaInventario();

            do
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Agregar un arma al inventario");
                Console.WriteLine("2. Mostrar el inventario");
                Console.WriteLine("3. Terminar el programa");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Seleccione un arma:");
                        Console.WriteLine("1. Espada");
                        Console.WriteLine("2. Arco");
                        Console.WriteLine("3. Pistola");
                        int armaSeleccionada = int.Parse(Console.ReadLine());

                        if (armaSeleccionada == 1)
                        {
                            ArmaBase espada = new Espada();
                            inventario.AgregarArma(espada);
                        }
                        else if (armaSeleccionada == 2)
                        {
                            ArmaBase arco = new Arco();
                            arco.Flecha = new Flecha();
                            inventario.AgregarArma(arco);
                        }
                        else if (armaSeleccionada == 3)
                        {
                            ArmaBase pistola = new Pistola();
                            pistola.Bala = new Bala();
                            inventario.AgregarArma(pistola);
                        }
                        break;

                    case 2:
                        inventario.MostrarInventario();
                        break;

                    case 3:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            } while (true);
        }
    }
}
