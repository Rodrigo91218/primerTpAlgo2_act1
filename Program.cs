using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Se ingresan 10 números. Se pide indicar cuál fue el mayor y cuantas veces se repitió. Utilice
            funciones.Utilice vectores.*/
            int varN = 1;
            double[] vec = new double[10];
            int i = 0;
            double mayor = 0;
            int cantMayor = 0;
            Console.WriteLine("Ingrese 10 números");
            Console.WriteLine($"Número {varN}");
            vec[i] = double.Parse(Console.ReadLine());
            mayor = vec[i];
            cantMayor++;
            varN++;
            i++;
            for (i = 1; i < vec.Length; i++)
            {
                Console.WriteLine($"Número {varN}");
                vec[i] = double.Parse(Console.ReadLine());
                if (vec[i] == mayor)
                {
                    cantMayor++;
                }

                if (vec[i] > mayor)
                {
                    mayor = vec[i];
                    cantMayor = 0;
                    cantMayor++;
                    
                }
                varN++;
                
            }
            Console.WriteLine($"\nEl número mayor que se ingreso fue: {mayor} y se repitió {cantMayor} veces.");
            Console.ReadKey();
           
        }
    }
}
