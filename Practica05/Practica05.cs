// 47
using System;

class Program05
{
    static void Main()
    {

        Console.WriteLine("Ingrese el primer numero:");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo numero:");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        bool esParNumero1 = (numero1 % 2 == 0);
        bool esParNumero2 = (numero2 % 2 == 0);

        if (esParNumero1 && esParNumero2)
        {
            Console.WriteLine("Ambos numeros son pares.");
        }
        else if (esParNumero1)
        {
            Console.WriteLine("Solo el primer numero es par.");
        }
        else if (esParNumero2)
        {
            Console.WriteLine("Solo el segundo numero es par.");
        }
        else
        {
            Console.WriteLine("Ninguno de los numeros es par.");
        }
    }
}
