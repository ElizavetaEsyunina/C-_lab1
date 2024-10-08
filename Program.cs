using System.Diagnostics.SymbolStore;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    //Задание 1. Методы
    //задача 1 (1)
    public double fraction(double x)
    {
        return Math.Round(Math.Abs(x - (int)x), 5);
    }

    //задача 3 (2)
    public int charToNum(char x)
    {
        return (x - '0');
    }

    //задача 5 (3)
    public bool is2Digits(int x)
    {
        return (Math.Abs(x) >= 10 && Math.Abs(x) < 100);
    }

    //задача 7 (4)
    public bool isInRange(int a, int b, int num)
    {
        int min = Math.Min(a, b);
        int max = Math.Max(a, b);
        return (min <= num && num <= max);
    }

    //задача 9 (5)
    public bool isEqual(int a, int b, int c)
    {
        return a == b && a == c;
    }

    //Задание 2. Условия
    //задача 1 (6)
    public int abs(int x)
    {
        if (x > 0) return x;
        else return -x;
    }

    //задача 3 (7)
    public bool is35(int x)
    {
        if ((x % 3 == 0 && x % 5 != 0) || (x % 5 == 0 && x % 3 != 0)) return true;
        return false;
    }

    //задача 5 (8)
    public int max3(int x, int y, int z)
    {
        int max = x;
        if (y > max) max = y;
        if (z > max) max = z;
        return max;
    }

    //задача 7 (9)
    public int sum2(int x, int y)
    {
        if (x + y >= 10 && x + y <= 19) return 20;
        return x + y;
    }

    //задача 9 (10)
    public String day(int x)
    {
        switch(x)
        {
            case 1: return "Понедельник";
            case 2: return "Вторник";
            case 3: return "Среда";
            case 4: return "Четверг";
            case 5: return "Пятница";
            case 6: return "Суббота";
            case 7: return "Воскресенье";
            default: return "Это не день недели";
        }
    }

    //Задание 3. Циклы
    //задача 1 (11)
    public String listNums(int x)
    {
        String result = "";
        for (int i = 0; i <= x; i++)
        {
            result += Convert.ToString(i);
            result += " ";
        }
        return result;
    }

    //задача 3 (12)
    public String chet(int x)
    {
        String result = "";
        for (int i = 0; i <= x; i += 2)
        {
            result += Convert.ToString(i);
            result += " ";
        }
        return result;
    }

    //задача 5 (13)
    public int numLen(long x)
    {
        int length = 0;
        x = Math.Abs(x);
        while (x / 10 > 0)
        {
            length++;
            x /= 10;
        }
        length += 1;
        return length;
    }

    //задача 7 (14)
    public void square(int x)
    {
       for (int i = 0; i < x; i++) //строки
        {
            for (int j = 0; j < x; j++) //столбцы
                Console.Write("*");
            Console.WriteLine();
        }
    }

    //задача 9 (15)
    public void rightTriangle(int x)
    {
        for (int i = 1; i <= x; i++) //строки
        {
            //столбцы
            for (int j = 0; j < x - i; j++) // пробелы для выравнивания по правому краю
                Console.Write(" ");
            for (int s = 0; s < i; s++) // звездочки
                Console.Write("*");
            Console.WriteLine();
        }
    }

    //Задание 4. Массивы
    //массивы 1 (16)
    public int findFirst(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x) return i;
        }
        return -1;
    }

    //массивы 3 (17)
    public int maxAbs(int[] arr)
    {
        int max = Math.Abs(arr[0]);
        for (int i = 0; i < arr.Length; i++)
        {
            if (Math.Abs(arr[i]) > max) max = Math.Abs(arr[i]);
        }
        return max;
    }

    //массивы 5 (18)
    public int[] add(int[] arr, int[] ins, int pos)
    {
        int[] result = new int[arr.Length + ins.Length];
        // Копируем элементы из arr до позиции pos
        for (int i = 0; i < pos; i++)
            result[i] = arr[i];

        // Вставляем элементы из ins
        for (int j = 0; j < ins.Length; j++)
            result[pos + j] = ins[j];

        // Копируем оставшиеся элементы из arr после позиции pos
        for (int i = pos; i < arr.Length; i++)
            result[ins.Length + i] = arr[i];

        return result;
    }

    //массивы 7 (19)
    public int[] reverseBack(int[] arr)
    {
        int[] result = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
            result[i] = arr[arr.Length - 1 - i];
        return result;
    }

    //массивы 9 (20)
    public int[] findAll(int[] arr, int x)
    {
        int k = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
                k++;
        }
        int[] result = new int[k];
        int index = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                result[index] = i;
                index++;
            }
        }
        return result;
    }

    private static void Main(string[] args)
    {
        Console.WriteLine("Лабораторная работа №1");
        Console.WriteLine("Выберите цифру от 1 до 20 чтобы посмотреть работу программы для конкретной задачи");
        int x = int.Parse(Console.ReadLine());
        Program task = new Program();
        switch (x)
        {
            case 1: //дробная часть
                Console.WriteLine("Введите вещественное число");
                if (double.TryParse(Console.ReadLine(), out double t1))
                    Console.WriteLine("Дробная часть введенного числа: " + task.fraction(t1));
                else Console.WriteLine("Введены некорректные данные");
                break;

            case 2: //букву в число
                Console.WriteLine("Введите цифру от 0 до 9, программа преобразует символ в соответствующее число");
                if ((char.TryParse(Console.ReadLine(), out char t2)) && (!char.IsLetter(t2)))
                    Console.WriteLine("Вы ввели символ: " + t2 + ". Код символа: " + (int)t2 + ". Он был преобразован в соответствующее число: " + task.charToNum(t2));
                else Console.WriteLine("Введены некорректные данные");
                break;

            case 3: //двузначное
                Console.WriteLine("Введите число");
                if (int.TryParse(Console.ReadLine(), out int t3) && task.is2Digits(t3))
                    Console.WriteLine("Введенное число " + t3 + " является двузначным");
                else Console.WriteLine("Введенное число " + t3 + " не двузначное");
                break;

            case 4: //диапазон
                Console.WriteLine("Введите границы числового диапазона");
                if (int.TryParse(Console.ReadLine(), out int a) && int.TryParse(Console.ReadLine(), out int b))
                {
                    Console.WriteLine("Введите любое число, программа проверит входит ли оно в указанный диапазон");
                    if (int.TryParse(Console.ReadLine(), out int num))
                    {
                        if (task.isInRange(a, b, num))
                        {
                            if (a < b) Console.WriteLine("Значение " + num + " лежит в диапазоне от " + a + " до " + b);
                            else Console.WriteLine("Значение " + num + " лежит в диапазоне от " + b + " до " + a);
                        }
                        else Console.WriteLine("Значение " + num + " не лежит в указанном диапазоне");
                    }
                    else Console.WriteLine("Неверный формат входных данных");
                }
                else Console.WriteLine("Неверный формат входных данных");                
                break;

            case 5: //равенство
                Console.WriteLine("Введите три числа");
                if (int.TryParse(Console.ReadLine(), out int d1) && (int.TryParse(Console.ReadLine(), out int d2)) && (int.TryParse(Console.ReadLine(), out int d3)))
                {
                    if (task.isEqual(d1, d2, d3)) Console.WriteLine("Все три введенных числа равны");
                    else Console.WriteLine("Введенные числа не равны");
                }
                else Console.WriteLine("Неверный формат входных данных");
                break;

            case 6: //модуль числа
                Console.WriteLine("Введите число");
                if (int.TryParse(Console.ReadLine(), out int t6))
                    Console.WriteLine("Вы ввели: " + t6 + ". Модуль числа: " + task.abs(t6));
                else Console.WriteLine("Неверный формат входных данных");
                break;

            case 7: //тридцать пять
                Console.WriteLine("Введите любое число");
                if (int.TryParse(Console.ReadLine(), out int t7))
                    if (task.is35(t7)) Console.WriteLine(task.is35(t7) + ", число " + t7 + " делится без остатка на 3 или на 5");
                    else Console.WriteLine(task.is35(t7) + ", число " + t7 + " не делится без остатка на 3 или на 5, либо оно делится и на 3 и на 5");
                else Console.WriteLine("Неверный формат входных данных");
                break;

            case 8: //тройной максимум
                Console.WriteLine("Введите любые три числа");
                if ((int.TryParse(Console.ReadLine(), out int digit1)) && (int.TryParse(Console.ReadLine(), out int digit2)) && (int.TryParse(Console.ReadLine(), out int digit3)))
                    Console.WriteLine("Максимальное число = " + task.max3(digit1, digit2, digit3));
                else Console.WriteLine("Неверный формат входных данных");
                break;

            case 9: //двойная сумма
                Console.WriteLine("Введите два числа");
                if ((int.TryParse(Console.ReadLine(), out int dig1)) && (int.TryParse(Console.ReadLine(), out int dig2)))
                {
                    if (task.sum2(dig1, dig2) == 20) Console.WriteLine("Значение суммы " + dig1 + " + " + dig2 + " входит в диспазон от 10 до 19. Результат работы программы: " + (task.sum2(dig1, dig2)));
                    else Console.WriteLine("Сумма " + dig1 + " + " + dig2 + " = " + (task.sum2(dig1, dig2)));
                }
                else Console.WriteLine("Неверный формат входных данных");
                break;

            case 10: //день недели
                Console.WriteLine("Введите номер дня недели");
                if (int.TryParse(Console.ReadLine(), out int t10)) Console.WriteLine(task.day(t10));
                else Console.WriteLine("Неверный формат входных данных");
                break;

            case 11: //числа подряд
                Console.WriteLine("Введите число x, программа выведет все числа от 0 до x включительно");
                if (int.TryParse(Console.ReadLine(), out int right_limit) && right_limit >= 0) Console.WriteLine("Числа от 0 до " + right_limit + ": " + task.listNums(right_limit));
                else if (right_limit < 0) Console.WriteLine("Правая граница диапазона должна быть больше нуля");
                else Console.WriteLine("Неверный формат входных данных");
                break;

            case 12: //четные числа
                Console.WriteLine("Введите число");
                if (int.TryParse(Console.ReadLine(), out int right_lim) && right_lim >= 0) Console.WriteLine("Четные числа от 0 до " + right_lim + ": " + task.chet(right_lim));
                else if (right_lim < 0) Console.WriteLine("Правая граница диапазона должна быть больше нуля");
                else Console.WriteLine("Неверный формат входных данных");
                break;

            case 13: //длина числа
                Console.WriteLine("Введите число, программа посчитает сколько в нем знаков");
                if (int.TryParse(Console.ReadLine(), out int chislo)) Console.WriteLine("Количество знаков в числе " + chislo + " = " + task.numLen(chislo));
                else Console.WriteLine("Неверный формат входных данных");
                break;

            case 14: //квадрат
                Console.WriteLine("Введите число x, программа выведет квадрат размером x*x");
                if (int.TryParse(Console.ReadLine(), out int size) && size > 0) task.square(size);
                else Console.WriteLine("Неверный формат входных данных");
                break;

            case 15: //правый треугольник
                Console.WriteLine("Введите число x, программа выведет треугольник высотой x, выровненный по правому краю");
                if (int.TryParse(Console.ReadLine(), out int height) && height > 0) task.rightTriangle(height);
                else Console.WriteLine("Неверный формат входных данных");
                break;

            case 16: // поиск первого значения
                Console.WriteLine("Введите количество чисел в массиве");
                int[] mas = new int[int.Parse(Console.ReadLine())];
                //заполнение массива случайными числами
                Random rand = new Random();
                for (int i = 0; i < mas.Length; i++)
                    mas[i] = rand.Next(0, 11);
                Console.WriteLine("Какое число надо найти в массиве?");
                int find = int.Parse(Console.ReadLine());
                int ans = task.findFirst(mas, find);
                //вывод массива
                Console.WriteLine("Исходный массив:");
                for (int i = 0; i < mas.Length; i++)
                    Console.Write(mas[i] + " ");
                Console.WriteLine();
                Console.WriteLine("Индекс первого вхождения числа " + find + " в массив: " + ans);
                break;

            case 17: // поиск масксимального
                Console.WriteLine("Введите количество чисел в массиве");
                int[] arr3 = new int[int.Parse(Console.ReadLine())];
                //заполнение массива случайными числами
                Random rand3 = new Random();
                for (int i = 0; i < arr3.Length; i++)
                    arr3[i] = rand3.Next(-30, 30);

                int ans3 = task.maxAbs(arr3);

                //вывод массива
                Console.WriteLine("Исходный массив:");
                for (int i = 0; i < arr3.Length; i++)
                    Console.Write(arr3[i] + " ");
                Console.WriteLine();
                Console.WriteLine("Наибольшее по модулю число в массиве: " + ans3);
                break;

            case 18: // добавление массива в массив
                Console.WriteLine("Введите количество чисел в массиве 1");
                int[] array = new int[int.Parse(Console.ReadLine())];
                //заполнение массива случайными числами
                Random random1 = new Random();
                for (int i = 0; i < array.Length; i++)
                    array[i] = random1.Next(-10, 10);

                Console.WriteLine("Введите количество чисел в массиве 2");
                int[] ins = new int[int.Parse(Console.ReadLine())];
                //заполнение массива случайными числами
                Random random2 = new Random();
                for (int i = 0; i < ins.Length; i++)
                    ins[i] = random2.Next(-10, 10);

                Console.WriteLine("Начиная с какой позиции вставлять элементы второго массива в первый?");
                int pos = int.Parse(Console.ReadLine());

                int[] new_mas = task.add(array, ins, pos);

                //вывод массивов
                Console.WriteLine("Исходный массив 1:");
                for (int i = 0; i < array.Length; i++)
                    Console.Write(array[i] + " ");
                Console.WriteLine();

                Console.WriteLine("Исходный массив 2:");
                for (int i = 0; i < ins.Length; i++)
                    Console.Write(ins[i] + " ");
                Console.WriteLine();

                Console.WriteLine("Новый массив:");
                for (int i = 0; i < new_mas.Length; i++)
                    Console.Write(new_mas[i] + " ");
                Console.WriteLine();
                break;

            case 19: //возвратный реверс
                Console.WriteLine("Введите количество чисел в массиве");
                int[] massiv = new int[int.Parse(Console.ReadLine())];
                //заполнение массива случайными числами
                Random random = new Random();
                for (int i = 0; i < massiv.Length; i++)
                    massiv[i] = random.Next(-30, 30);

                int[] new_massiv = task.reverseBack(massiv);

                //вывод массивов
                Console.WriteLine("Исходный массив:");
                for (int i = 0; i < massiv.Length; i++)
                    Console.Write(massiv[i] + " ");
                Console.WriteLine();

                Console.WriteLine("Тот же массив в обратную сторону:");
                for (int i = 0; i < new_massiv.Length; i++)
                    Console.Write(new_massiv[i] + " ");
                Console.WriteLine();
                break;

            case 20: //все вхождения
                Console.WriteLine("Введите количество чисел в массиве");
                int[] mas1 = new int[int.Parse(Console.ReadLine())];
                //заполнение массива случайными числами
                Random rand_1 = new Random();
                for (int i = 0; i < mas1.Length; i++)
                    mas1[i] = rand_1.Next(0, 6);

                Console.WriteLine("Какое число нужно найти в массиве?");
                int find_x = int.Parse(Console.ReadLine());

                int[] x_mas = task.findAll(mas1, find_x);

                //вывод массивов
                Console.WriteLine("Исходный массив:");
                for (int i = 0; i < mas1.Length; i++)
                    Console.Write(mas1[i] + " ");
                Console.WriteLine();

                if (x_mas.Length != 0)
                {
                    Console.WriteLine("Индексы вхождений числа " + find_x + " в исходный массив: ");
                    for (int i = 0; i < x_mas.Length; i++)
                        Console.Write(x_mas[i] + " ");
                    Console.WriteLine();
                }
                else Console.WriteLine("Не было найдено ни одного вхождения числа " + find_x + " в массив");
                break;

            default: break;
        }
    }
}