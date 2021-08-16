using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico1
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Mi Programa en C#");
            List<Persona> lista = new List<Persona>();
            do
            {
                Persona per = new Persona();
                try
                {
                    Console.Write("Nombre: ");
                    per.Nombre = Console.ReadLine();

                    Console.Write("Apellido: ");
                    per.Apellido = Console.ReadLine();

                    Console.Write("Documento de Identidad: ");
                    per.Documento = Console.ReadLine();

                    Console.Write("Fecha de Nacimiento: ");
                    per.FechaNacimiento = Convert.ToDateTime(Console.ReadLine());

                }
                catch (Exception e) {
                    Console.WriteLine("ERROR: " + e.Message);
                }
                lista.Add(per);

                Console.WriteLine("exit para salir o cuialquier otra tecla para continuar: ");
              
            } while (!Console.ReadLine().Equals("exit"));

            lista.ForEach(p =>
            { Console.WriteLine(p.Nombre + " | " + p.Apellido + " | " + p.Documento + " | " + p.FechaNacimiento ); });
            Console.ReadLine();

        }
    }
}
