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

            // Evaluamos la operación & and logico de valores boolean
            Console.WriteLine("++++++++ Operacion AND Lógico de valores boolen ++++++++");
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
            Console.WriteLine();

            //************** Operacion Bit a Bit ***************
            Console.WriteLine("++++++++ Operacion AND Lógico bit a bit ++++++++");
            uint a2 = 0b_1111_1000;
            uint b2 = 0b_1001_1101;
            uint c2 = a2 & b2;
            Console.WriteLine(Convert.ToString(c2, toBase: 2));
            // Output:
            // 10011000
            Console.WriteLine();

            //************** Operacion Unario address-of ***************
            // Para poder ejecutar el codigo siguiente se debe habilitar la compilacion insegura (unsafe)
            // Esto se hace en propiedades del proyecto - ficha compilacion y marcar la casilla: 
            // permitir codigo no seguro
            //Console.WriteLine("++++++++ Operacion Unario adress-of ++++++++");
            //unsafe
            //{
            //    int number = 27;
            //    int* pointerToNumber = &number;
            //    Console.WriteLine($"Value of the variable: {number}");
            //    Console.WriteLine($"Address of the variable: {(long)pointerToNumber:X}");
            //    // Output is similar to: 
            //    // Value of the variable: 27
            //    // Address of
            //}
        }

        // Metodo que se evalua independientemente del valor del primer operando
        // Este metodo siempre devuelve un valor true
        static bool SecondOperand()
        {
            Console.WriteLine("Second operand is evaluated.");
            return true;
        }

    }
}
