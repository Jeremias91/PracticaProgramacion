//63
using System;

class Practica08{
    static void Main()
    {
        int contr;

        do{
            Console.WriteLine("Ingresa la contraseña: ");
            contr = Convert.ToInt32(Console.ReadLine());

            if(contr!= 1111){
            Console.WriteLine("Constraseña incorrecta, intente de nuevo");

            }

        }while(contr!= 1111);

        Console.WriteLine("Contraseña Correcta");

    }
}