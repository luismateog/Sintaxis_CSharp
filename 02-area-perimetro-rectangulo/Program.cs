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

            // 2 y 3. Cálculo inicial de área y perímetro
            int area = width * height;
            int perimeter = (2 * width) + (2 * height);

            // 4. Incrementar width en 3 unidades (operador compuesto +=)
            width += 3;

            // 5. Decrementar height en 2 unidades (operador compuesto -=)
            height -= 2;

            // 6. Recalcular y actualizar valores de area y perimeter
            area = width * height;
            perimeter = (2 * width) + (2 * height);

            // 7. Mostrar valores finales por consola
            Console.WriteLine("--- Valores Finales del Rectángulo ---");
            Console.WriteLine($"Ancho (width): {width}");
            Console.WriteLine($"Alto (height): {height}");
            Console.WriteLine($"Área (area): {area}");
            Console.WriteLine($"Perímetro (perimeter): {perimeter}");
        }
    }
}
