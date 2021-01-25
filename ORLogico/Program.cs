using System;

namespace ORLogico
{
    class Program
    {
        static void Main(string[] args)
        {
            // El resultado de a | b es true si a o b (cualquiera de los dos) se evalúan como true. 
            // De lo contrario, el resultado es false.
            // El operador | evalua ambos operandos incluso aunque el izquierdo se evalue como true

            // Evaluamos la operación | (OR Logico) de valores boolean
            Console.WriteLine("++++++++ Operacion OR Lógico de valores boolean ++++++++");
            bool a = true | SecondOperand();
            Console.WriteLine(a);
            // Output:
            // Second operand is evaluate
            // true

            bool b = false | SecondOperand();
            Console.WriteLine(a);
            // Output:
            // Second operand is evaluate
            // true

            Console.WriteLine();

            //************** Operacion Bit a Bit ***************
            Console.WriteLine("++++++++ Operacion OR Lógico bit a bit ++++++++");
            uint a2 = 0b_1010_0000;
            uint b2 = 0b_1001_0001;
            uint c2 = a2 | b2;
            Console.WriteLine(Convert.ToString(c2, toBase: 2));
            // Output:
            // 10110001
            Console.WriteLine();
        }

        static bool SecondOperand()
        {
            Console.WriteLine("Second operand is evaluated.");
            return true;
        }
    }
}
