using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaEJ;



class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("===================================");
            Console.WriteLine("    Calculadora de Áreas");
            Console.WriteLine("===================================");
            Console.ResetColor();
            Console.WriteLine("Seleccione una figura:");
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Rectángulo");
            Console.WriteLine("3. Triángulo");
            Console.WriteLine("4. Círculo");
            Console.WriteLine("5. Salir");
            Console.WriteLine("===================================");

            int eleccion = int.Parse(Console.ReadLine());

            switch (eleccion)
            {
                case 1:
                    Console.Write("Ingrese la longitud del lado del cuadrado: ");
                    double squareSide = double.Parse(Console.ReadLine());
                    Square square = new Square(squareSide);
                    Console.WriteLine($"El área del cuadrado es: {square.CalculateArea()} unidades cuadradas");
                    break;

                case 2:
                    Console.Write("Ingrese la longitud del rectángulo: ");
                    double rectLength = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el ancho del rectángulo: ");
                    double rectWidth = double.Parse(Console.ReadLine());
                    Rectangle rectangle = new Rectangle(rectLength, rectWidth);
                    Console.WriteLine($"El área del rectángulo es: {rectangle.CalculateArea()} unidades cuadradas");
                    break;

                case 3:
                    Console.Write("Ingrese la longitud de la base del triángulo: ");
                    double triangleBase = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura del triángulo: ");
                    double triangleHeight = double.Parse(Console.ReadLine());
                    Triangle triangle = new Triangle(triangleBase, triangleHeight);
                    Console.WriteLine($"El área del triángulo es: {triangle.CalculateArea()} unidades cuadradas");
                    break;

                case 4:
                    Console.Write("Ingrese el radio del círculo: ");
                    double circleRadius = double.Parse(Console.ReadLine());
                    Circle circle = new Circle(circleRadius);
                    Console.WriteLine($"El área del círculo es: {circle.CalculateArea()} unidades cuadradas");
                    break;

                case 5:
                    Console.WriteLine("Saliendo del programa.");
                    return;

                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Opción inválida. Por favor seleccione una opción válida.");
                    Console.ResetColor();
                    break;
            }

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}
