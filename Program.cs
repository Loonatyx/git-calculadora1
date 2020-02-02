using System;

namespace Calculadora1
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto_a_centrar = "Calculadora Basica"; // centra en la consola el texto dentro de las comillas.
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (texto_a_centrar.Length / 2)) + "}", texto_a_centrar));


            string valor1, valor2; // crera 2 variables de tipo string.
            Console.WriteLine("ingrese el primer valor"); //muestra en la consola el texto dentro de las comillas.
            Console.WriteLine("\n"); //crea un salto de linea.
            valor1 = Console.ReadLine(); //recibe el valor que ingresemos en la consola y lo guarda en la variable valor1.
            Console.WriteLine("\n");
            Console.WriteLine("ingrese el segundo valor");
            Console.WriteLine("\n");
            valor2 = Console.ReadLine(); //recibe el valor que ingresemos en la consola y lo guarda en la variable valor2.
            Console.WriteLine("\n");

            operadores suma = new operadores(valor1, valor2); //se intancia la clase operadores con el nombre suma.
            double adicion;

            adicion = suma.getsuma(); //se llama al metodo getsuma de la clase instanciada de nombre suma, para que realicela suma de los valores.
            Console.WriteLine("El resultado de la suma es: {0} ", adicion);
            Console.ReadKey();
        }
    }
}
