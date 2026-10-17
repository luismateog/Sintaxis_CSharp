using System;

namespace EjerciciosBasicos
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Variable entera
            int age = 25;

            // 2. Variable decimal
            double height = 1.75;

            // 3. Variable booleana
            bool is_student = true;

            // 4. Variable de texto
            string name = "Ana";

            // 5. Variable de tipo carácter
            char grade = 'A';

            // Impresión en consola con mensajes descriptivos
            Console.WriteLine($"La edad es: {age}");
            Console.WriteLine($"La altura es: {height}");
            Console.WriteLine($"¿Es estudiante?: {is_student}");
            Console.WriteLine($"El nombre es: {name}");
            Console.WriteLine($"La calificación es: {grade}");
        }
    }
}