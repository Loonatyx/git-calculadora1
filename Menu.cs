using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora1
{
    class Menu
    {
        public void listaopciones()
        {
            string opcion = "0";

            do
            {
                Console.Clear();

                string texto_a_centrar = "Calculadora Basica"; // centra en la consola el texto dentro de las comillas.
                Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (texto_a_centrar.Length / 2)) + "}", texto_a_centrar));
                Console.WriteLine("\n");
                Console.WriteLine("Que deseas realizar?\n" +

           "\n1.- Suma" +
           "\n2.- Resta" +
           "\n3.- Multiplicacion" +
           "\n4.- Division" +
           "\n5.- Potenciacion" +
           "\n6.- Raiz" +
           "\n7.- Porcentaje" +
           "\n8.- Promedio Estudiantil" +
           "\nG.- Guardar Archivo" +
           "\nM.- Modificar Archivo" +
           "\nL.- Leer Archivo");

                Console.WriteLine("\n");
                opcion = Console.ReadLine();
                Console.WriteLine("\n");
                switch (opcion)
                {
                    case "1":// si se selecciona 1 se ejecuta lo siguiente.
                        Console.WriteLine("Has seleccionado realizar una suma");
                        Console.WriteLine("\n");
                        string valor1, valor2; // crea 2 variables de tipo string.
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
                        break;
                    case "2":
                        Console.WriteLine("Has seleccionado realizar una Resta");
                        Console.WriteLine("\n");
                        string valor3, valor4; // crea 2 variables de tipo string.
                        Console.WriteLine("ingrese el primer valor"); //muestra en la consola el texto dentro de las comillas.
                        Console.WriteLine("\n"); //crea un salto de linea.
                        valor3 = Console.ReadLine(); //recibe el valor que ingresemos en la consola y lo guarda en la variable valor3.
                        Console.WriteLine("\n");
                        Console.WriteLine("ingrese el segundo valor");
                        Console.WriteLine("\n");
                        valor4 = Console.ReadLine(); //recibe el valor que ingresemos en la consola y lo guarda en la variable valor4.
                        Console.WriteLine("\n");
                        
                        operadores resta = new operadores(valor3, valor4);
                        double diferencia;

                        diferencia = resta.getresta();
                        Console.WriteLine("El resultado de la resta es: {0}", diferencia);
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Has seleccionado realizar una Multiplicacion");
                        Console.WriteLine("\n");
                        string valor5, valor6; // crea 2 variables de tipo string.
                        Console.WriteLine("ingrese el primer valor"); //muestra en la consola el texto dentro de las comillas.
                        Console.WriteLine("\n"); //crea un salto de linea.
                        valor5 = Console.ReadLine(); //recibe el valor que ingresemos en la consola y lo guarda en la variable valor5.
                        Console.WriteLine("\n");
                        Console.WriteLine("ingrese el segundo valor");
                        Console.WriteLine("\n");
                        valor6 = Console.ReadLine(); //recibe el valor que ingresemos en la consola y lo guarda en la variable valor6.
                        Console.WriteLine("\n");

                        operadores multiplo = new operadores(valor5, valor6);
                        double factor;

                        factor = multiplo.getmultiplo();
                        Console.WriteLine("El resultado de la multiplicacion es: {0}", factor);
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Has seleccionado realizar una Division");
                        Console.WriteLine("\n");
                        string valor7, valor8; // crea 2 variables de tipo string.
                        Console.WriteLine("ingrese el primer valor"); //muestra en la consola el texto dentro de las comillas.
                        Console.WriteLine("\n"); //crea un salto de linea.
                        valor7 = Console.ReadLine(); //recibe el valor que ingresemos en la consola y lo guarda en la variable valor7.
                        Console.WriteLine("\n");
                        Console.WriteLine("ingrese el segundo valor");
                        Console.WriteLine("\n");
                        valor8 = Console.ReadLine(); //recibe el valor que ingresemos en la consola y lo guarda en la variable valor8.
                        Console.WriteLine("\n");

                        operadores divisor = new operadores(valor7, valor8);
                        double dividendo;

                        dividendo = divisor.getdivisor();
                        Console.WriteLine("El resultado de la division es: {0}", dividendo);
                        Console.ReadKey();                      
                        break;
                    case "5":
                        Console.WriteLine("Has seleccionado realizar una potenciacion");
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Has seleccionado obtener una raiz cuadrada");
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Has seleccionado obtener un porcentaje");
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Has seleccionado obtener el promedio de un estudiante");
                        Console.ReadKey();
                        break;
                    case "G":
                        Console.WriteLine("Has seleccionado Guardar este archivo");
                        Console.ReadKey();
                        break;
                    case "M":
                        Console.WriteLine("Has seleccionado Modificar un archivo existente");
                        Console.ReadKey();
                        break;
                    case "L":
                        Console.WriteLine("Has seleccionado Leer un archivo existente");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Has seleccionado una opcion incorrecta");
                        Console.ReadKey();
                        break;
                }
            } while (opcion != "0");
        }
    }
}
