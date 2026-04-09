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
            for (i = 0; i < vec.Length; i++)
            {
                Console.WriteLine($"Número {varN}");
                vec[i] = double.Parse(Console.ReadLine());
                
               

                if (vec[i] > mayor)
                {
                    mayor = vec[i];
                    cantMayor = 0;
                    
                }
                if (vec[i] == mayor)
                {
                    cantMayor++; 
                }
               
                varN++;
                
            }
            Console.WriteLine($"\nEl número mayor que se ingreso fue: {mayor} y se repitio {cantMayor} veces.");
           
        }
    }
}
