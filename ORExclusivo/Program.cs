using System;

namespace ORExclusivo
{
    class Program
    {
        static void Main(string[] args)
        {
            //El operador ^ calcula el operador OR Exclusivo lógico conocido como XOR Lógico
            Console.WriteLine("++++++++ Operacion OR Exclusivo de valores boolean ++++++++");
            Console.WriteLine($"True ^ True =  {true ^ true}");      //Output: false
            Console.WriteLine($"True ^ False =  {true ^ false}");    //Output: true
            Console.WriteLine($"False ^ True =  {false ^ true}");    //Output: true
            Console.WriteLine($"False ^ False =  {false ^ false}");  //Output: false
            Console.WriteLine();

            //obtenemos el mismo resultado utilizando el operador !=  (Not Equal)
            Console.WriteLine("++++++++ Mismo resultado con el operador != (Not Equal) ++++++++");
            Console.WriteLine($"True != True =  {true != true}");     //Output: false
            Console.WriteLine($"True != False =  {true != false}");   //Output: true
            Console.WriteLine($"False != True =  {false != true}");   //Output: true
            Console.WriteLine($"False != False =  {false != false}"); //Output: false
        }
    }
}
