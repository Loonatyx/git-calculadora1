using System;

namespace Calculadora1
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto_a_centrar = "Calculadora Basica";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (texto_a_centrar.Length / 2)) + "}", texto_a_centrar));
            
            
            
            
            
            
            
            
            
            
            Console.ReadKey();
        }
    }
}
