using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCsharpBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("https://www.youtube.com/watch?v=YrtFtdTTfv0");
            Console.WriteLine("Hora 12:50");
            Console.WriteLine("Hola C#!");
            Console.WriteLine("Variables:");
            Variables();
            Console.WriteLine("Operaciones:");
            Operaciones();
            Console.WriteLine("Funciones:");
            Console.WriteLine("Funcion sin return:");
            FuncionSinReturn();
            Console.WriteLine("Funcion con return:");
            Console.Write("Ingrese el primer número: ");
            int nume1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el segundo número: ");
            int nume2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(FuncionConReturn(nume1, nume2));

            Console.WriteLine();
            Console.WriteLine("Estructura if-else if-else");
            if (nume1 > nume2)
            {
                Console.WriteLine($"El número 1 es mayor y es: {nume1}");
            }
            else if (nume2 > nume1)
            {
                Console.WriteLine($"El número 2 es mayor y es: {nume2}");
            }
            else
            {
                Console.WriteLine($"Los números son iguales. Son {nume1}");
            }

            Console.WriteLine();
            Console.WriteLine("Estructura switch");
            switch (nume1)
            {
                case int n when (n <= 0):
                    Console.WriteLine("El número es menor o igual que 0");
                    break;
                case int n when (n >= 1 && n <= 10):
                    Console.WriteLine("El número 1 está entre 1 y 10");
                    break;
                case int n when (n >= 11 && n <= 20):
                    Console.WriteLine("El número 1 está entre 11 y 20");
                    break;
                default:
                    Console.WriteLine("El número es mayor que 20");
                    break;
            }

            Console.WriteLine();
            Console.WriteLine("Nullabilidad");
            string name = null; // No reconoce nullables todavia?

            Console.Write("Ingrese su nombre: ");
            name = Console.ReadLine();
            Console.WriteLine($"Tu nombre es: {name}.");

            Console.WriteLine();
            Console.WriteLine("Arrays");
            string[] weekDays = { "Lunes", "Martes", "Miércoles", "Jueves", "Viernes", "Sábado", "Domingo" };
            Console.WriteLine($"Hoy es {weekDays[6]}.");
            Console.WriteLine($"El array weekDays tiene un tamaño de {weekDays.Length}.");

            Console.WriteLine();
            Console.WriteLine("Bucles");
            Console.WriteLine("Bucle for");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"For con i vale {i}");
            }

            Console.WriteLine("Bucle while");
            int contador = 1;
            while (contador <= 5)
            {
                Console.WriteLine($"Contador vale: {contador}");
                contador++;
            }

            Console.WriteLine("Bucle do while");
            contador = 1;
            do
            {
                Console.WriteLine($"Contador vale: {contador}");
                contador++;
            } while (contador <= 5);

            Console.WriteLine();
            Console.WriteLine("Listas");

            List<string> listaInmutable = new List<string> { "Uno", "Dos", "Tres" };
            Console.WriteLine("Lista inmutable:");
            Console.WriteLine(listaInmutable.Count);
            Console.WriteLine(listaInmutable[0]);
            Console.WriteLine(listaInmutable.IndexOf("Dos"));
            Console.WriteLine(listaInmutable.Contains("Tres"));

            List<string> listaMutable = new List<string> { "Uno", "Dos", "Tres" };
            Console.WriteLine("Lista mutable:");
            listaMutable.Add("Cuatro");
            listaMutable.Remove("Dos");
            listaMutable[1] = "Nuevo valor";
            foreach (var item in listaMutable)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Sets");

            HashSet<string> setInmutable = new HashSet<string> { "Uno", "Dos", "Tres" };
            Console.WriteLine(setInmutable.Count);
            Console.WriteLine(setInmutable.Contains("Dos"));

            HashSet<string> setMutable = new HashSet<string> { "Uno", "Dos", "Tres" };
            setMutable.Add("Cuatro");
            setMutable.Remove("Dos");
            foreach (var item in setMutable)
            {
                Console.WriteLine(item);
            }
        }

        static void Variables()
        {
            Console.WriteLine("Tipo Enteros:");
            Console.WriteLine($"Byte (8 bits) más grande: {byte.MaxValue}");
            Console.WriteLine($"Byte más chico: {byte.MinValue}");
            Console.WriteLine($"Short (16 bits) más grande: {short.MaxValue}");
            Console.WriteLine($"Short más chico: {short.MinValue}");
            Console.WriteLine($"Int (32 bits) más grande: {int.MaxValue}");
            Console.WriteLine($"Int más chico: {int.MinValue}");
            Console.WriteLine($"Long (64 bits) más grande: {long.MaxValue}");
            Console.WriteLine($"Long más chico: {long.MinValue}");

            Console.WriteLine();
            Console.WriteLine("Tipo Punto flotante:");
            Console.WriteLine($"Float (32 bits) más grande: {float.MaxValue}");
            Console.WriteLine($"Float más chico positivo: {float.MinValue}");
            Console.WriteLine($"Double (64 bits) más grande: {double.MaxValue}");
            Console.WriteLine($"Double más chico positivo: {double.MinValue}");

            Console.WriteLine();
            Console.WriteLine("Tipo Decimal (alta precisión):");
            Console.WriteLine($"Decimal más grande: {decimal.MaxValue}");
            Console.WriteLine($"Decimal más chico: {decimal.MinValue}");

            Console.WriteLine();
            Console.WriteLine("Tipo Booleanos:");
            Console.WriteLine($"Este boolean es {true}");
            Console.WriteLine($"Este boolean es {false}");
        }

        static void Operaciones()
        {
            Console.WriteLine("Aritméticas:");
            Console.WriteLine("Sumar +");
            Console.WriteLine("Restar -");
            Console.WriteLine("Dividir /");
            Console.WriteLine("Multiplicar *");
            Console.WriteLine("Resto %");

            Console.WriteLine();
            Console.WriteLine("Lógicas:");
            Console.WriteLine("Disyunción ||");
            Console.WriteLine("Conjunción &&");
            Console.WriteLine("Negación !");

            Console.WriteLine();
            Console.WriteLine("Comparación:");
            Console.WriteLine("Igual a ==");
            Console.WriteLine("Diferente a !=");
            Console.WriteLine("Menor que <");
            Console.WriteLine("Menor o igual que <=");
            Console.WriteLine("Mayor que >");
            Console.WriteLine("Mayor o igual que >=");
        }

        static void FuncionSinReturn()
        {
            Console.WriteLine("Esta es la función sin return.");
        }

        static string FuncionConReturn(int num1, int num2)
        {
            return $"El resultado es: {num1 + num2}";
        }
    }
}



/*
namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hola mundo!");


            // Variables
            int numero= int.MaxValue;
            Console.WriteLine($"El valor maximo de un int es: {numero}.");
            // Hasta aca Main
        }
    }
}
*/