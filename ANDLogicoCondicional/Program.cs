using System;

namespace ANDLogicoCondicional
{
    class Program
    {
        static void Main(string[] args)
        {

            // El operador AND lógico condicional &&, también denominado operador AND lógico "de cortocircuito"
            // calcula el operador AND lógico de sus operandos. 
            // El resultado de x && y es true si x y y se evalúan como true, de lo contrario, el resultado es false.
            // Si x se evalúa como false, y no se evalúa.

            bool a = false && SecondOperand();
            Console.WriteLine($"El resultado de a && SecondOperand es {a}");
            Console.WriteLine($"Como el valor de a es False la funcion SecondOperand ya no se evalua");
            // Output:
            // False
            Console.WriteLine();

            bool b = true && SecondOperand();
            Console.WriteLine($"El resultado de b && SecondOperand es {b}");
            Console.WriteLine($"Como el valor de b es True la funcion SecondOperand se evalua");
            // Output:
            // Second operand is evaluated.
            // True
            Console.WriteLine();


            Console.WriteLine("Aqui la combinación de valores y sus resultados");
            Console.WriteLine($"True  &&  True = {true && true}");
            Console.WriteLine($"True  &&  False = {true && false}");
            Console.WriteLine($"False &&  True = {false && true}");
            Console.WriteLine($"False &&  False = {false && false}");
        }

        static bool SecondOperand()
        {
            Console.WriteLine("Second operand is evaluated.");
            return true;
        }
    }
}
