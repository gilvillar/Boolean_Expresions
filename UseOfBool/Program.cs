using System;

namespace UseOfBool
{
    class Program
    {
        static void Main(string[] args)
        {
            // crear una variable de tipo bool llamada result y asignar el valor inicial en false
            bool result = false;

            // Realizamos una simple comparación y asignamos el resultado a la variable result
            // En este caso, comprobamos si el literal 2 es igual al literal 2
            // El resultado de esta comparación es verdadero (true) y la variable result  
            // Ahora contendrá el valor booleano true
            Console.WriteLine($"La variable result tiene el valor inicial: {result}");

            result = 2 == 2; // En este ejemplo, la comparación tiene mayor jerarquia que la asignación
                             // asi que primero se realiza la comparación 2 == 2 
                             // posteriormene el resultado se asigna a la variable result
            Console.WriteLine($"Se evalua la condicion 2 == 2 y se asigna a la variable result");
            
            Console.WriteLine($"Ahora la variable result tiene el valor: {result}"); // enviamos el valor de la variable result a la consola
        }
    }
}
