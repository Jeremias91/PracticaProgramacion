using System;

public class EstudianteProfesorTest
{
    public static void Main(string[] args)
    {
        Persona persona = new Persona();
        persona.Saludar();

        Estudiante estudiante = new Estudiante();
        estudiante.SetEdad(20);
        estudiante.Saludar();   
        estudiante.VerEdad();   
        estudiante.Estudiar(); 

        Profesor profesor = new Profesor();
        profesor.SetEdad(40);   
        profesor.Saludar();     
        profesor.Explicar();   
    }
}