using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            char op = 's';
            string archivo;
            int l;


            while (op == 's')
            {

                Console.Clear();
                Console.WriteLine("\n 1.Crear Variable \n 2.Salida");
                l = int.Parse(Console.ReadLine());



                if (l == 1)
                {
                    StreamWriter ar;
                    archivo = Console.ReadLine();
                    Console.WriteLine("Nombre del programa: ");
                    ar = File.AppendText(Console.ReadLine() + ".txt");
                    ar.Close();
                }
                if (l == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Presione no para su salida");
                    op = char.Parse(Console.ReadLine());
                    Console.Clear();
                }
            }

        }
    }
}