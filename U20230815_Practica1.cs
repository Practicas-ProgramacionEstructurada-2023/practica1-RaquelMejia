using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //DECLARACION DE VARIABLES 
            string? nombre;
            int edad;
            string? direccion;
            int telefono;
            string? universidad;
            string? carrera; 
            string? facultad;
            int ciclo;

            Console.WriteLine("\n****Practica 1 - Programacion Estructurada**\n");
            Console.WriteLine("Ingresa tu nombre completo:");//Obtener Datos
            nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingresa tu edad:");//Obtener Datos
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingresa tu direccion:");//Obtener Datos
            direccion = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingresa tu telefono:");//Obtener Datos
            telefono = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingresa la universiversidad donde estudia:");//Obtener Datos
            universidad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingresa tu carrera:");//Obtener Datos
            carrera = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingresa tu facultad:");//Obtener Datos
            facultad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingresa tu ciclo:");//Obtener Datos
            ciclo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            //IMPRIMIENDO DATOS

            Console.WriteLine("Su nombre completo es: "+ nombre);
            Console.WriteLine("Su edad es: "+ edad);
            Console.WriteLine("Su dirrecion es: "+ direccion);
            Console.WriteLine("Su telefono es: "+ telefono);
            Console.WriteLine("Universidad que estudia: "+ universidad);
            Console.WriteLine("Su carrera es: "+ carrera);
            Console.WriteLine("Su facultad es: "+ facultad);
            Console.WriteLine("Su ciclo es: "+ ciclo);


        }
    }
}