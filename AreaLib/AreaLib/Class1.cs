namespace AreaLib
{
    /*
     В данной библиотеке реализованы следующие методы:
     1) Нахождение площади круга через радиус
     2) Нахождение площади треугольника через три стороны либо через две стороны, если он прямоугольный
     3) Нахождение площади квадрата по стороне
     4) Определение является ли треугольник прямоугольным
     5) Экспериментальный метод, где я постарался реализовать все эти методы через один сеанс в консоли (Compile-time)
     в этом методе - попытка реализации примитивного диалога с пользователем для определения того, что он хочет получить
     и рассчет площадей по его запросу
     */

    public static class Formula
    {
        public static double Сircle(double radius) //площадь круга через радиус
        {
            double area;

            if (radius > 0)
            {
                area = System.Math.PI * radius * radius;

            }
            else
            {
                area = 0;
            }
            return area;


        }
        public static double TrngABC(double firstSide, double secondSide, double thirdSide)//площадь треугольника через стороны
        {
            double area;

            if ((firstSide > 0) && (secondSide > 0) && (thirdSide > 0))
            {
                double perimeter = (firstSide + secondSide + thirdSide) / 2;//полупериметр
                area = System.Math.Sqrt(perimeter * (perimeter - firstSide) * (perimeter - secondSide) * (perimeter - thirdSide));//площадь

            }
            else
            {
                area = 0;
            }
            return area;



        }
        public static double TrngRight(double firstSide, double secondSide) //площадь прямоугольного треугольника
        {
            double area;
            if ((firstSide > 0) && (secondSide > 0))
            {
                area = (firstSide * secondSide) / 2;



            }
            else
            {

                area = 0;
            }
            return area;



        }
        public static double Square(double side) //площадь квадрата
        {
            double area;
            if (side > 0)
            {

                area = side * side;
            }
            else
            {

                area = 0;
            }

            return area;

        }
        public static string CheckTrng(double firstSide, double secondSide, double hypotenuse) //проверка треугольника на прямоугольность
        {
            string area;
            if (firstSide * firstSide + secondSide * secondSide == hypotenuse * hypotenuse)
            {

                area = "triangle is right!";
            }
            else
            {

                area = "tringle is not right!";
            }

            return area;

        }


        public static void FindFig() //метод для работы с запросами пользователя
        {
            Console.WriteLine("Choose your figure!");       //выбор фигуры
            Console.WriteLine("Circle, Triangle or Square"); // из предложенного списка
            string choose = Console.ReadLine();             //получение значений, которые после будут обработаны
            switch (choose)                                 //обработка выбора пользователя
            {
                case "Circle":
                    {
                        Console.WriteLine("Input radius:");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(Сircle(radius));


                    }
                    break;
                case "Triangle": //здесь я пробую сшить определение прямоугольности треугольника и нахождение его площади
                    {
                        Console.WriteLine("Choose Right triangle or Regular triangle:");
                        Console.WriteLine("If you do not know, choose 'Check triangle'");

                        string typeTring = Console.ReadLine();
                        switch (typeTring)
                        {

                            case "Right triangle"://Если пользователь уверен, что его треугольник прямоугольный
                            Found1:
                                {
                                    

                                    Console.WriteLine("Input two sides");
                                    Console.WriteLine("First side is:");
                                    double firstSide = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Second side is:");
                                    double secondSide = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Your area is:");
                                    Console.WriteLine(TrngRight(firstSide, secondSide));

                                }
                                break;

                            case "Regular triangle"://если пользователь уверен, что его треугольник не прямоугольный
                                Found2:
                                {
                                    Console.WriteLine("Input three sides");
                                    Console.WriteLine("First side is:");
                                    double firstSide = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Second side is:");
                                    double secondSide = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Third side is:");
                                    double thirsSide = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Your area is:");
                                    Console.WriteLine(TrngABC(firstSide, secondSide, thirsSide));

                                }
                                break;
                            case "Check triangle"://определение прямоугольности треугольника
                                {
                                    Console.WriteLine("Input two sides and hypotenuse");
                                    Console.WriteLine("First side is:");
                                    double firstSide = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Second side is:");
                                    double secondSide = Convert.ToDouble(Console.ReadLine());
                                    Console.WriteLine("Hypotenuse is:");
                                    double hypotenuse = Convert.ToDouble(Console.ReadLine());
                                    
                                    if (CheckTrng(firstSide, secondSide, hypotenuse)=="triangle is right!")
                                    {
                                        Console.WriteLine("Your tringle is right! Now you can find it's area");
                                        goto Found1;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Your tringle is NOT right! Now you can find it's area");
                                        goto Found2;
                                    }

                                }
                                

                            default:
                                Console.WriteLine("Incorrect value");
                                break;
                        }


                    }
                    break;

                case "Square":
                    {
                        Console.WriteLine("Input side:");
                        double side = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine(Square(side));
                    }
                    break;
                default:
                    Console.WriteLine("Incorrect value");
                    break;
            }


        }





    }

}