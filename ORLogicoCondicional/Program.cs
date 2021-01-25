using System;

namespace ORLogicoCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            // El operador OR lógico condicional ||, también denominado operador OR lógico "de cortocircuito"
            // Calcula el operador OR lógico de sus operandos. 
            // El resultado de x || y es true si x o y se evalúan como true.De lo contrario, el resultado es false.
            // Si x se evalúa como true, y no se evalúa.

            bool a = true || SecondOperand();
            Console.WriteLine($"El resultado de a || SecondOperand es {a}");
            Console.WriteLine($"Como el valor de a es True el metodo SecondOperand ya no se evalua");
            // Output:
            // True
            Console.WriteLine();

            bool b = false || SecondOperand();
            Console.WriteLine($"El resultado de b || SecondOperand es {b}");
            Console.WriteLine($"Como el valor de b es False el metodo SecondOperand se evalua");
            // Output:
            // Second operand is evaluated.
            // True
            Console.WriteLine();


            Console.WriteLine("Aqui la combinación de valores y sus resultados");
            Console.WriteLine($"True  ||  True = {true || true}");
            Console.WriteLine($"True  ||  False = {true || false}");
            Console.WriteLine($"False ||  True = {false || true}");
            Console.WriteLine($"False ||  False = {false || false}");
        }

        static bool SecondOperand()
        {
            Console.WriteLine("Second operand is evaluated.");
            return true;
        }
    }
}
