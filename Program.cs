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
            
            int varN = 1; //Inicializo una variable en valor 1 y luego ira incrementando con el bucle for asi queda mas estetico para el usuario cuando le pida ingresar los números.
            double[] vec = new double[10]; // Creo el vector de tamaño 10 vacío (0 al 9).
            int i = 0; // Variable para recorrer el vector inicializada en 0.
            double mayor = 0; // Variable double para que el usuario puedo colocar cualquier tipo de dato númerico (int, float, decimal, double, etc.)
            int cantMayor = 0; // Variable que sirva como contador para saber la cantidad de veces que se repitio el mayor  valor.
            Console.WriteLine("Ingrese 10 números");
            vec[i] = LeerNumero($"Número {varN}: ");
            mayor = vec[i];// El primer valor que se ingresa es el mayor. Esto para evitar errores más adelante.
            cantMayor++;// Se eleva en 1 la cantidad de veces que se repite el mayor valor
            varN++;
            i++; // Se desplaza el casillero del vector al siguiente del 0 al 1.
            for (i = 1; i < vec.Length; i++) //Bucle for para repetir la misma secuencia de ingreso de valores y que coincida con el tamaño del vector.
            {
                vec[i] = LeerNumero($"Número {varN}: ");
                if (vec[i] == mayor)// Si el valor del vector en la posición 'i' es igual al valor en la variable 'mayor' se sumara el valor de 1 en la variable 'cantMayor'.
                {
                    cantMayor++;
                }

                if (vec[i] > mayor)// Este algoritmo es el que se encarga de siempre poner como mayor al número mas alto que se ingresa.
                {
                    mayor = vec[i];
                    cantMayor = 0;
                    cantMayor++;
                    
                }
                varN++;
                
            }
            if(cantMayor == 1)
            {
                Console.WriteLine($"\nEl número mayor que se ingreso fue: {mayor} y se repitió {cantMayor} vez."); // El programa muestra dos resultados distintos en caso que el mayor solo se repita una unica vez.
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"\nEl número mayor que se ingreso fue: {mayor} y se repitió {cantMayor} veces.");// Se muestran los resultados finales. Interpolación para colocar variables más facil.
                Console.ReadKey();//Pausa la consola para que no se cierre al terminar el programa.
            }



            double LeerNumero(string mensaje)// Función para simplificar el uso del mismo código dentro y fuera del bucle for.
            {
                double valor; //El número que ingresamos

                Console.Write(mensaje); 

                while (!double.TryParse(Console.ReadLine(), out valor))
                {
                    Console.WriteLine("Error!. Ingrese solo valores numéricos.");
                    Console.Write(mensaje);
                }

                return valor; //Lo que devuelve la función 
            }

        }
    }
}
