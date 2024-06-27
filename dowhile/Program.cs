using System;
using System.Collections.Concurrent;

class Program
{
    static void Main()
    {
        string nombre, apellido;
        bool continuar;

        do
        {
            Console.WriteLine("Ingrese su nombre: \n");
            nombre = Console.ReadLine().Trim();

            Console.WriteLine("Ingrese su apellido: \n");
            apellido = Console.ReadLine().Trim();

            Console.WriteLine($"Hola, {nombre} {apellido}!");

            Console.WriteLine("Desea Ingresar otro nombre y apellido? (s/n)");
            string repuesta = Console.ReadLine().ToLower();

            continuar = (repuesta == "s");
        } while( continuar );

        Console.WriteLine("Gracias por utilizar este programa. Presione cualquier tecla para cerrar");
        Console.ReadKey();

        
    }
}