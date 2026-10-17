using System;

namespace EjerciciosBasicos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración e inicialización de variables de distintos tipos
            int age = 25;
            double height = 1.75;
            bool isStudent = true;
            string name = "Ana";
            char grade = 'A';

            // Impresión en consola con mensajes descriptivos
            Console.WriteLine("La edad es: " + age);
            Console.WriteLine("La altura es: " + height + " m");
            Console.WriteLine("¿Es estudiante?: " + isStudent);
            Console.WriteLine("El nombre es: " + name);
            Console.WriteLine("La calificación es: " + grade);
        }
    }
}