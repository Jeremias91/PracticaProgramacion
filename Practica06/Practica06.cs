//59
using System;

class Program06
{
    static void Main()
    {
        
        Console.WriteLine("Ingrese una letra o cifra numerica:");
        char input = Console.ReadKey().KeyChar;
        Console.WriteLine();

        switch (input)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
            case 'A':
            case 'E':
            case 'I':
            case 'O':
            case 'U':
                Console.WriteLine("Es una vocal.");
                break;

            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
                Console.WriteLine("Es una cifra numérica.");
                break;

            default:
                if (char.IsLetter(input))
                {
                    Console.WriteLine("Es una consonante.");
                }
                else
                {
                    Console.WriteLine("No es una letra ni una cifra numérica.");
                }
                break;
        }
    }
}
