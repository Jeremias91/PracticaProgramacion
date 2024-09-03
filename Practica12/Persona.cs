using System;

public class Persona
{
    protected int edad;

    public void Saludar()
    {
        Console.WriteLine("¡Hola!");
    }

    public void SetEdad(int edad)
    {
        this.edad = edad;
    }
}