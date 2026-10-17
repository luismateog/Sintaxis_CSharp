using System;

namespace EjerciciosBasicos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Datos del producto
            string productName = "Laptop Gamer";
            double price = 1200.50;
            int quantity = 2;
            double discountRate = 0.10; // 10% de descuento

            // Cálculos
            double subtotal = price * quantity;
            double discount = subtotal * discountRate;
            double total = subtotal - discount;

            // Impresión por consola utilizando únicamente interpolación de strings ($"...")
            Console.WriteLine("================ RESUMEN DE COMPRA ================");
            Console.WriteLine($"Producto: {productName}");
            Console.WriteLine($"Precio unitario: ${price:F2}");
            Console.WriteLine($"Cantidad comprada: {quantity}");
            Console.WriteLine($"Subtotal: ${subtotal:F2}");
            Console.WriteLine($"Descuento aplicado (10%): ${discount:F2}");
            Console.WriteLine($"Total a pagar: ${total:F2}");
            Console.WriteLine("===================================================");
        }
    }
}
