using System;

namespace OperadorTernario
{
    class Program
    {
        static void Main(string[] args)
        {
            //El operador condicional ?:, también conocido como operador condicional ternario
            // Evalúa una expresión booleana y devuelve el resultado de una de las dos expresiones
            // En función de que la expresión booleana se evalúe como true o false.
            
            Random rnd = new Random();
            int num = 0;
            num = rnd.Next(100); // Genera un numero aleatorio entre 1 y 100
                                 // Y lo asigna a la variable num                                 

            string type = num % 2 == 0 ? "par" : "impar"; // Si el resultado de num % 2 es igual a cero
                                                          // El operador devolverá una cadena indicando un numero par
                                                          // En caso contrario devolverá una cadena indicando numero impar

            Console.WriteLine($"El número generado es: {num}");

            Console.WriteLine($"Evaluamos la expresión: {num} % 2 ? \"par\" : \"impar\"");
            Console.WriteLine($"El resultado es: el número {num} es un número {type}");
        }
    }
}
