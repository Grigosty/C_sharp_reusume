using AreaLib;
class UsingTests
{
    static void Main(string[] args)
    {

        //тест на проверку работы метода нахождения площади круга через радиус
        Console.WriteLine("Unit test 1. Круг");
        Console.WriteLine();
        Console.WriteLine("Test 1. Площадь круга:");
        Console.WriteLine("Входное значение: Радиус = 10");
        Console.WriteLine($"Ожидаемый результат: {Math.PI * 10 * 10} ");
        Console.WriteLine($"Рассчетный результат: {Formula.Сircle(10)}");
        Console.WriteLine();
        Console.WriteLine("Test 2. Площадь круга:");
        Console.WriteLine("Входное значение: Радиус = -1");
        Console.WriteLine($"Ожидаемый результат: 0 ");
        Console.WriteLine($"Рассчетный результат: {Formula.Сircle(-1)}");
        Console.WriteLine();
        Console.WriteLine("Test 3. Площадь круга:");
        Console.WriteLine("Входное значение: Радиус = 0");
        Console.WriteLine($"Ожидаемый результат: 0 ");
        Console.WriteLine($"Рассчетный результат: {Formula.Сircle(0)}");
        Console.WriteLine();
        Console.WriteLine();


        //тест на проверку метода нахождения площади треугольника по трем сторонам
        Console.WriteLine("Unit test 2. Треугольник");
        Console.WriteLine();
        Console.WriteLine("Test 1. Площадь треугольника по трем сторонам:");
        Console.WriteLine("Входное значение: Первая сторона = 2, Вторая сторона = 3, Третья сторона = 4 ");
        double perimeter = (2 + 3 + 4) / 2;
        Console.WriteLine($"Ожидаемый результат: {System.Math.Sqrt(perimeter * (perimeter - 2) * (perimeter - 3) * (perimeter - 4))} ");
        Console.WriteLine($"Рассчетный результат: {Formula.TrngABC(2, 3, 4)}");
        Console.WriteLine();
        Console.WriteLine("Test 2. Площадь треугольника по трем сторонам, если одна из них имеет недопустимое значение:");
        Console.WriteLine("Входное значение: Первая сторона = 2, Вторая сторона = 3, Третья сторона = -5 ");
        Console.WriteLine($"Ожидаемый результат: 0 ");
        Console.WriteLine($"Рассчетный результат: {Formula.TrngABC(2, 3, -5)}");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

        //тест на проверку работы метода нахождения площади прямоугольного треугольника
        Console.WriteLine("Unit test 3. Прямоугольный треугольник");
        Console.WriteLine();
        Console.WriteLine("Test 1. Площадь прямоугольного треугольника:");
        Console.WriteLine("Входное значение: Первая сторона = 2, Вторая сторона = 3");
        Console.WriteLine($"Ожидаемый результат: {2 * 3 / 2} ");
        Console.WriteLine($"Рассчетный результат: {Formula.TrngRight(2, 3)}");
        Console.WriteLine();
        Console.WriteLine("Test 2. Площадь прямоугольного треугольника:");
        Console.WriteLine("Входное значение: Первая сторона = 2, Вторая сторона = -1");
        Console.WriteLine($"Ожидаемый результат: 0 ");
        Console.WriteLine($"Рассчетный результат: {Formula.TrngRight(2, -1)}");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        //тест на проверку работы метода определения прямоугольности треугольника
        Console.WriteLine("Unit test 4. Проверка треугольника");
        Console.WriteLine();
        Console.WriteLine("Test 1. Треугольник НЕ прямоугольный!!:");
        Console.WriteLine("Входное значение: Первая сторона = 1, Вторая сторона = 2, Третья сторона = 3");
        Console.WriteLine($"Ожидаемый результат: Triangle is not right ");
        Console.WriteLine($"Рассчетный результат: {Formula.CheckTrng(1, 2, 3)}");
        Console.WriteLine();
        Console.WriteLine("Test 2. Треугольник прямоугольный!!:");
        Console.WriteLine("Входное значение: Первая сторона = 3, Вторая сторона = 4, Третья сторона = 5");
        Console.WriteLine($"Ожидаемый результат: triangle is right ");
        Console.WriteLine($"Рассчетный результат: {Formula.CheckTrng(3, 4, 5)}");


        Console.WriteLine();
        Console.WriteLine();








    }
}
