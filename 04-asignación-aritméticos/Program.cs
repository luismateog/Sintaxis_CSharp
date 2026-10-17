using System;

namespace EjerciciosBasicos
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Declarar variables iniciales
            int width = 7;
            int height = 5;

            // 2 y 3. Cálculo inicial usando operadores aritméticos
            int area = width * height;
            int perimeter = (2 * width) + (2 * height);

            // 4 y 5. Uso de operadores de asignación compuesta
            width += 3;   // Equivalente a: width = width + 3
            height -= 2;  // Equivalente a: height = height - 2

            // 6. Recálculo con los nuevos valores
            area = width * height;
            perimeter = (2 * width) + (2 * height);

            // 7. Mostrar resultados
            Console.WriteLine("--- Resultados del Rectángulo ---");
            Console.WriteLine("Nuevo Ancho: " + width);
            Console.WriteLine("Nuevo Alto: " + height);
            Console.WriteLine("Área Final: " + area);
            Console.WriteLine("Perímetro Final: " + perimeter);
        }
    }
}
