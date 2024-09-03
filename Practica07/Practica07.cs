//29
using System;

class Practica07
{
    static void Main()
    {
        
        Console.WriteLine("Ingrese el primer numero: ");
        int a = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("Ingrese el Segundo numero: ");
        int b = Convert.ToInt32(Console.ReadLine());

        int resultado1 = (a + b) * (a - b );

        int resultado2 = (a * a) - (b * b);

        Console.WriteLine("El resultado de (a + b) * (a - b) '" + resultado1 + "' y el resultado de a2-b2 es '" + resultado2 + "'" );
    }
}