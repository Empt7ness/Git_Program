using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        List<BaseShape> shapes = new List<BaseShape>();

        try
        {
            while (true)
            {
                Console.Write("Введіть 1 для трапеції, 0 для ромба. Для завершення введіть 2: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 2) break;

                if (choice != 0 && choice != 1)
                    throw new ArgumentException("Помилка: Дозволено лише 0, 1 або 2.");

                Console.Write("Введіть сторону1: ");
                double side1 = double.Parse(Console.ReadLine());
                if (side1 <= 0) throw new ArgumentException("Помилка: Має бути більше 0");

                Console.Write("Введіть висоту: ");
                double height = double.Parse(Console.ReadLine());
                if (height <= 0) throw new ArgumentException("Помилка: Має бути більше 0.");

                BaseShape shape;

                if (choice == 1)
                {
                    Console.Write("Введіть сторону2: ");
                    double side2 = double.Parse(Console.ReadLine());
                    if (side2 <= 0) throw new ArgumentException("Помилка: Має бути більше 0.");

                    shape = new Trapezoid(side1, side2, height);
                }
                else
                {
                    shape = new Rhombus(side1, height);
                }

                shapes.Add(shape);

                Console.WriteLine("Фігуру додано.");
            }

            Console.WriteLine("\nВсі введені фігури:");
            foreach (var s in shapes)
            {
                Console.WriteLine(s.GetInfo());
                Console.WriteLine("Площа: " + s.GetArea());
                Console.WriteLine();
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Помилка: Дозволені лише числа.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
