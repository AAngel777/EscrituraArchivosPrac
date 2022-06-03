using System;
using System.IO;

namespace EscrituraArchivosprac
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[10];
            for (int i = 0; i <= 9; i++)
            {
                Console.WriteLine("Ingrese el nombre " + i + ":");
                string linea;
                linea = Console.ReadLine();
                nombres[i] = (linea);
            }
            Console.WriteLine("Nombres escritos: ");
            for (int i= 0; i<=9;i++)
            {
                Console.WriteLine("Numero " + i+1 + ":" + nombres[i]);
            }

            StreamWriter sw = new StreamWriter("nombres.txt", true);
            foreach(string nombre in nombres)
            {
                sw.WriteLine(nombre);
            }
            sw.Close();

            Console.WriteLine("Escribiendo...");
            Console.ReadLine();
        }
    } 
}
