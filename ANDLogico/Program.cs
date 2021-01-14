using System;

namespace ANDLogico
{
    class Program
    {
        public static void Main(string[] args)
        {
            // El resultado de a & b es true si a y b se evalúan como true. 
            // De lo contrario, el resultado es false.
            // El operador & evalua ambos operandos incluso aunque el izquierdo se evalue como false
            
            // Evaluamos la operación & and logico
            bool a = false & SecondOperand();
            Console.WriteLine(a);
            // Output:
            // Second operand is evaluate
            // false

            bool b = true & SecondOperand();
            Console.WriteLine(b);
            // Output:
            // Second operand is evaluate
            // true


            // Metodo que se evalua independientemente del valor del primer operando
            // Este metodo siempre devuelve un valor true
            bool SecondOperand()
            {
                Console.WriteLine("Second operand is evaluated.");
                return true;
            }
        }

    }
}
