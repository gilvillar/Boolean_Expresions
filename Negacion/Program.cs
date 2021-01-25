using System;

namespace Negacion
{
    class Program
    {
        static void Main(string[] args)
        {
            // El operador ! de prefijo unario calcula la negación lógica de su operando.
            // Es decir, genera true si el operando se evalúa como false
            // Y false si el operando se evalúa como true.

            bool passed = false;
            // invertimos el valor de la variable false al momento de enviarlo a consola
            Console.WriteLine($"El valor de la variable passed es: {passed}");
            Console.WriteLine($"Invertimos el valor de la variable passed con el operador de negacion:");
            Console.WriteLine($"!passed: {!passed}");
            Console.WriteLine();

            // invertimos el valor true de manera directa
            Console.WriteLine($"Aplicamos el operador de negacion al valor true");
            Console.WriteLine($"!true: {!true}");
        }
    }
}
