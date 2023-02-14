namespace Консольные_задачи_на_построение_алгоритма
{
    //в данном проекте собраны некоторые задачи, которые мне требовалось решить на тех или иных курсах, либо по учебе.
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задача 1. Рассчет простых чисел в заданных границах");
            Console.WriteLine("Введите границы:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Сумма всех простых чисел в диапазоне:");
            SchetSimple(a, b);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Задача 2.Рисоване ёлочки с заданной высотой");
            Console.WriteLine("Введите высоту ёлочки:");
            int h = int.Parse(Console.ReadLine());
            Elochka(h);
            Console.WriteLine("Задача 3.Сравнение цифр в двух числах.Смотрим по первому числу");
            Console.WriteLine("Введите первое число:");
            string a1 = Console.ReadLine();
            Console.WriteLine("Введите второе число:");
            string b1 = Console.ReadLine();
            Sravnenie(a1, b1);
            Console.WriteLine("Задача 4. Реализация двух методов: Первый берет кратные семи числа из диапазона");
            Console.WriteLine("Второй отбирает каждое второе число и выводит список");
            Console.WriteLine("Введите начало диапазона");
            int a2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите конец диапазона");
            int b2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Список ваших чисел:");
            MultiTwo(a2, b2);
            Console.WriteLine("Задачи 5 и 6 схожи, поэтому идут вместе");
            Console.WriteLine("В начале кодируем при помощи дельта кодирования, дальше декодируем");
            Console.WriteLine("Задача 5. На вход набор чисел для дельта-кодирования: {-5,14,2,74,10,0,61} , на выход, собственно, кодирование:");
            Delta();
            Console.WriteLine("Задача 6. Теперь наоборот");
            Console.WriteLine("На вход: {8,25,-48,15,19,-36}");
            Console.WriteLine("На выход:");
            DeltaDecod();



        }

        /* 1. Напишите программу, которая считает сумму всех простых чисел в определенном диапазоне. 
         * Простое число - целое положительное число, имеющее ровно два различных натуральных делителя - единицу и самого себя. 
         * Число 1 не является ни простым, ни составным числом, так как у него только один делитель - 1.*/
        public static void SchetSimple(int a, int b)
        {

            int c = 0;
            int sum;

            if (b > 0)
            {
                for (int i = a; i <= b; i++)
                {
                    if (i < 2)
                    {
                        continue;
                    }
                    else
                    {
                        for (int j = 2; j <= i; j++)
                        {
                            if (i % j != 0)
                            {
                                continue;
                            }
                            else
                            {
                                if (j < i)
                                {
                                    break;
                                }
                                else
                                {
                                    if (j == i)
                                    {
                                        c = c + i;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                c = 0;
            }
            sum = c;
            Console.WriteLine($"Сумма простых чисел = {sum}");
        }

        /*Это творческое задание. 
         * Необходимо написать программу, которая рисует в консоли ёлочку из звездочек, высота ёлочки вводится пользователем в консоль.
         * Обратите внимание, что первый символ в основании ёлочки это первый символ данной строки, а ее вершина находится на первой строке.*/
        public static void Elochka(int h)
        {

            int a = 1;
            int hp = h - 1;
            string b = "*";
            string probel = " ";
            for (int i = 0; i < h; i++)
            {
                for (int z = 0; z < hp; z++)
                {
                    Console.Write(probel);
                }
                for (int j = 0; j < a; j++)
                {
                    Console.Write(b);
                }
                a += 2;
                hp -= 1;
                Console.WriteLine();
            }
        }
        /*Ваша программа получает на вход два числа в строковом формате, но теперь они  могут быть разной длины.
         * Найдите все уникальные элементы первого числа (значения, которые встречаются  только 1 раз в обоих массивах)*/
        public static void Sravnenie(string a, string b)
        {

            
            char[] x = a.ToCharArray();//массив, в котором расположены цифры из первого числа
            char[] y = b.ToCharArray();//массив, в котором расположены цифры из второго числа
            char[] z = new char[x.Length];
            int counter = 0;
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < y.Length; j++)
                {

                    if (x[i] != y[j])
                    {//если цифра из первого числа не равна цифре из второго:

                        if ((j == y.Length - 1))
                        {
                            if (x[i] != y[j])
                            {
                                z[i] = x[i];
                            }
                        }//тут мы прописываем условие для последнего шага цикла, т.е для проверки последней цифры
                        else
                        {
                            continue;
                        }
                        continue;
                    }
                    else
                    {
                        break;
                    }
                    // в конце этого цикла мы получим массив z, в котором будут храниться цифры из первого числа
                    // не совпадающие с цифрами из второго



                }
            }
            //теперь нам нужно проверить какие цифры из первого числа могут повторяться и выбросить их
            char[] l = new char[x.Length];
            for (int i1 = 0; i1 < z.Length; i1++)
            {

                for (int j1 = 0; j1 < z.Length; j1++)
                {
                    if (i1 != j1)
                    {
                        if (z[i1] == z[j1])
                        {
                            l[i1] = z[i1];
                        }
                    }

                }


            }
            for (int i2 = 0; i2 < z.Length; i2++)
            {
                for (int j2 = 0; j2 < z.Length; j2++)
                {
                    if (z[i2] == l[j2])
                    {
                        z[i2] = (char)0;
                    }
                }
            }

            foreach (var num in z)
            {
                if (num > 0)
                {
                    Console.WriteLine($"Уникально число {num}");
                }
            }
        }

        /*Вам так же нужно написать два метода:

          Один берет числа из определенного диапазона и возвращает список тех чисел, которые кратны семи, кроме ноля

          Другой выводит в консоль через пробел значения каждого второго элемента такого списка*/

        public static void MultiTwo(int a2,int b2)
        {
            
            PrintEven(GetMultiple(a2, b2));
             static List<int> GetMultiple(int startValue, int endValue)
            {
                List<int> numbers = new List<int>();

                int counter = startValue;
                while (counter <= endValue)
                {

                    if ((counter != 0) && (counter % 7 == 0))
                    {
                        numbers.Add(counter);
                    }

                    counter++;
                }
                return numbers;

            }
             static void PrintEven(List<int> numbers)
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    if (i % 2 == 1)
                    {
                        Console.Write($"{numbers[i]} ");
                    }
                }

            }
        }
        //Дельта-кодирование:
        public static void Delta()
        {
            int[] array = { -5, 14, 2, 74, 10, 0, 61 };
            DeltaKod(array);
             static void DeltaKod(int[] array)
            {
                int[] newArray = new int[array.Length];
                for (int i = 0; i < newArray.Length; i++)
                {
                    if (i == 0)
                    {
                        newArray[i] = array[i];
                    }
                    else
                    {
                        newArray[i] = array[i] - array[i - 1];
                    }
                }
                foreach (var x in newArray)
                {
                    Console.Write($"{x} ");
                }

            }
        }
        public static void DeltaDecod()
        {
            int[] deltaArray = { 8, 25, -48, 15, 19, -36 };
            DeltaDecoding(deltaArray);
            static void DeltaDecoding(int[] array)
            {
                int[] newArray = new int[array.Length];
                for (int i = 0; i < newArray.Length; i++)
                {
                    if (i == 0)
                    {
                        newArray[i] = array[i];
                    }
                    else
                    {
                        newArray[i] = newArray[i - 1] + array[i];
                    }
                }
                foreach (var x in newArray)
                {
                    Console.Write($"{x} ");
                }

            }
        }
    }
}
    
