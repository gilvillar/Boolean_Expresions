using System;

namespace ComplementoBtiaBit
{
    class Program
    {
        static void Main(string[] args)
        {
            // El operador ~ genera un complemento bit a bit de su operando al invertir cada bit
            uint a = 0b_0000_1111_0000_1111_0000_1111_0000_1100;

            // El operador invierte cada bit de su operando, si es 1 lo vuelve 0 y si es 0 lo vuelve 1
            uint b = ~a;
            Console.WriteLine("El resultado de aplicar el operador ~ (Complemento bit a bit)");
            Console.WriteLine("al valor 00001111000011110000111100001100");
            Console.Write("     Es: ");
            Console.WriteLine(Convert.ToString(b, toBase: 2));
            // Output:
            // 11110000111100001111000011110011
        }
    }
}
