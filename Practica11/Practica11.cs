//92
using System;

class Practica11
{
    static void Main()
    {
        Console.WriteLine("Ingrese un numero:");
        int numero = Convert.ToInt32(Console.ReadLine());
        int contador = 1;

        while (contador <= numero)
        {
            if (contador % 9 == 0)
            {
                Console.WriteLine(contador);
            }

            contador++;
        }
    }
}