//1. a) Примитивные типы: определение, инициализация, ввод/вывод
//using System;

//class Program
//{
//    static void Main()
//    {
//        // Примитивные типы
//        bool b = true;
//        byte bt = 255;
//        sbyte sbt = -128;
//        char ch = 'A';
//        decimal dec = 10.5m;
//        double dbl = 3.1415;
//        float fl = 2.5f;
//        int i = 42;
//        uint ui = 100;
//        long l = 1234567890;
//        ulong ul = 12345678901234567890;
//        short sh = -32768;
//        ushort ush = 65535;

//        // Вывод значений
//        Console.WriteLine($"bool: {b}, byte: {bt}, sbyte: {sbt}, char: {ch}");
//        Console.WriteLine($"decimal: {dec}, double: {dbl}, float: {fl}");
//        Console.WriteLine($"int: {i}, uint: {ui}, long: {l}, ulong: {ul}");
//        Console.WriteLine($"short: {sh}, ushort: {ush}");

//        // Ввод значений
//        Console.Write("Введите целое число: ");
//        int input = Convert.ToInt32(Console.ReadLine());
//        Console.WriteLine($"Вы ввели: {input}");
//    }
//}







//b) Явное и неявное приведение + класс Convert
//using System;
//class Conversions
//{
//    static void Main()
//    {
//        // Неявное приведение
//        int a = 10;
//        long b = a;         // int → long
//        float c = b;        // long → float
//        double d = c;       // float → double
//        decimal e = a;      // int → decimal

//        // Явное приведение
//        double x = 9.8;
//        int y = (int)x;     // double → int
//        long z = (long)x;   // double → long
//        byte bt = (byte)y;  // int → byte
//        short sh = (short)z;// long → short
//        char ch = (char)y;  // int → char

//        // Convert
//        string str = "123";
//        int num = Convert.ToInt32(str);
//        bool flag = Convert.ToBoolean("true");
//        double dbl = Convert.ToDouble("3.14");
//        Console.WriteLine($"Convert: {num}, {flag}, {dbl}");
//    }
//}







//c) Упаковка и распаковка (Boxing / Unboxing)
//using System;

//class BoxingDemo
//{
//    static void Main()
//    {
//        int val = 123;
//        object boxed = val;         // упаковка
//        int unboxed = (int)boxed;   // распаковка
//        Console.WriteLine($"Boxed: {boxed}, Unboxed: {unboxed}");
//    }
//}










//d) Неявно типизированная переменная (var)
//using System;

//class VarDemo
//{
//    static void Main()
//    {
//        var message = "Hello, world!";
//        Console.WriteLine(message);
//    }
//}





//e) Nullable переменная
//using System;

//class NullableDemo
//{
//    static void Main()
//    {
//        int? age = null;
//        if (age.HasValue)
//            Console.WriteLine($"Возраст: {age.Value}");
//        else
//            Console.WriteLine("Возраст не указан");
//    }
//}








//f) Ошибка при повторном присваивании var
//using System;
//class VarError
//{
//    static void Main()
//    {
//        var number = 10;     // number имеет тип int
//        // number = "text";  // ❌ Ошибка: нельзя присвоить строку переменной типа int
//    }
//}







//2
//using System;
//using System.Text;

//class Program
//{
//    static void Main()
//    {
//        // Сравнение названий украшений
//        string item1 = "Diamond Whisper";
//        string item2 = "Diamond Whisper";
//        string item3 = new string("Diamond Whisper".ToCharArray());

//        Console.WriteLine($"item1 == item2: {item1 == item2}"); // True
//        Console.WriteLine($"item1 == item3: {item1 == item3}"); // True
//        Console.WriteLine($"ReferenceEquals(item1, item2): {object.ReferenceEquals(item1, item2)}"); // True
//        Console.WriteLine($"ReferenceEquals(item1, item3): {object.ReferenceEquals(item1, item3)}"); // False

//        Console.WriteLine("\n---");

//        // Операции со строками: оформление заказа
//        string brand = "Aurora";
//        string collection = "Celestial";
//        string piece = "Necklace";

//        string productName = $"{brand} {collection} {piece}";
//        Console.WriteLine($" Название изделия: {productName}");

//        string copy = string.Copy(collection);
//        Console.WriteLine($" Копия названия коллекции: {copy}");

//        string highlight = productName.Substring(7, 9);
//        Console.WriteLine($" Выделено: {highlight}");

//        string[] parts = productName.Split(' ');
//        Console.WriteLine(" Разделено:");
//        foreach (var part in parts)
//            Console.WriteLine($"• {part}");

//        string greeting = productName.Insert(0, "Добро пожаловать в бутик «");
//        greeting += "»!";
//        Console.WriteLine($" Приветствие: {greeting}");

//        string trimmed = greeting.Remove(0, 22);
//        Console.WriteLine($" После удаления: {trimmed}");

//        string clientName = "Анна";
//        int bonusPoints = 1200;
//        string message = $" Уважаемая {clientName}, вам начислено {bonusPoints} бонусов за покупку!";
//        Console.WriteLine($" Сообщение клиенту: {message}");

//        Console.WriteLine("\n---");

//        // Пустая и null строка
//        string empty = "";
//        string missing = null;

//        Console.WriteLine($"string.IsNullOrEmpty(empty): {string.IsNullOrEmpty(empty)}");
//        Console.WriteLine($"string.IsNullOrEmpty(missing): {string.IsNullOrEmpty(missing)}");

//        Console.WriteLine($"empty.Length: {empty.Length}");
//        Console.WriteLine($"missing == null: {missing == null}");

//        Console.WriteLine("\n---");

//        // StringBuilder: создание описания товара
//        StringBuilder builder = new StringBuilder("SapphireGlow");
//        builder.Remove(8, 3); // Удалим "Glow"
//        builder.Insert(0, " Новинка: "); // Вставим в начало
//        builder.Append(" — колье из белого золота"); // Добавим описание

//        Console.WriteLine($" Описание: {builder.ToString()}");
//    }
//}






//3
//using System;

//class Program
//{
//    static void Main()
//    {
//        // a. Целый двумерный массив (матрица)
//        int[,] matrix = {
//            { 10, 20, 30 },
//            { 40, 50, 60 },
//            { 70, 80, 90 }
//        };

//        Console.WriteLine(" Матрица:");
//        for (int i = 0; i < matrix.GetLength(0); i++)
//        {
//            for (int j = 0; j < matrix.GetLength(1); j++)
//            {
//                Console.Write($"{matrix[i, j],4} ");
//            }
//            Console.WriteLine();
//        }

//        Console.WriteLine("\n---");

//        // b. Одномерный массив строк
//        string[] jewelryItems = { "Кольцо", "Браслет", "Серьги", "Цепочка", "Брошь" };

//        Console.WriteLine(" Украшения:");
//        foreach (var item in jewelryItems)
//            Console.WriteLine($"• {item}");

//        Console.WriteLine($" Длина массива: {jewelryItems.Length}");

//        // Изменение элемента по вводу пользователя
//        Console.Write("Введите позицию для замены (0–4): ");
//        int pos = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Введите новое название украшения: ");
//        string newItem = Console.ReadLine();

//        if (pos >= 0 && pos < jewelryItems.Length)
//        {
//            jewelryItems[pos] = newItem;
//            Console.WriteLine(" Обновлённый список:");
//            foreach (var item in jewelryItems)
//                Console.WriteLine($"• {item}");
//        }
//        else
//        {
//            Console.WriteLine(" Неверная позиция.");
//        }

//        Console.WriteLine("\n---");

//        // c. Ступенчатый массив вещественных чисел
//        double[][] prices = new double[3][];
//        prices[0] = new double[2];
//        prices[1] = new double[3];
//        prices[2] = new double[4];

//        Console.WriteLine(" Введите цены для украшений:");
//        for (int i = 0; i < prices.Length; i++)
//        {
//            for (int j = 0; j < prices[i].Length; j++)
//            {
//                Console.Write($"Цена [{i}][{j}]: ");
//                prices[i][j] = Convert.ToDouble(Console.ReadLine());
//            }
//        }

//        Console.WriteLine(" Таблица цен:");
//        for (int i = 0; i < prices.Length; i++)
//        {
//            Console.Write($"Строка {i}: ");
//            for (int j = 0; j < prices[i].Length; j++)
//            {
//                Console.Write($"{prices[i][j]:F2} ");
//            }
//            Console.WriteLine();
//        }

//        Console.WriteLine("\n---");

//        // d. Неявно типизированные переменные
//        var gemstoneTypes = new[] { "Алмаз", "Рубин", "Сапфир" }; // массив строк
//        var description = "Коллекция 'Звёздный блеск'";           // строка

//        Console.WriteLine(" Камни:");
//        foreach (var gem in gemstoneTypes)
//            Console.WriteLine($"• {gem}");

//        Console.WriteLine($" Описание: {description}");
//    }
//}






//4
//using System;

//class Program
//{
//    static void Main()
//    {
//        // a. Кортеж из 5 элементов
//        (int, string, char, string, ulong) personInfo = (25, "Anna", 'F', "Designer", 12345678901234567890);

//        // b. Вывод кортежа целиком и выборочно
//        Console.WriteLine(" Полный кортеж:");
//        Console.WriteLine(personInfo);

//        Console.WriteLine(" Выборочные элементы:");
//        Console.WriteLine($"1: {personInfo.Item1}, 3: {personInfo.Item3}, 4: {personInfo.Item4}");

//        Console.WriteLine("\n---");

//        // c. Распаковка кортежа
//        // Способ 1: Явное указание типов
//        (int age, string name, char gender, string role, ulong id) = personInfo;
//        Console.WriteLine($" {name}, {age} лет, {gender}, {role}, ID: {id}");

//        // Способ 2: Использование var
//        var (a, b, c, d, e) = personInfo;
//        Console.WriteLine($" Распаковка через var: {b}, {a}, {c}");

//        // Способ 3: Использование _
//        (_, string onlyName, _, string onlyRole, _) = personInfo;
//        Console.WriteLine($" Имя и роль: {onlyName}, {onlyRole}");

//        Console.WriteLine("\n---");

//        // d. Сравнение двух кортежей
//        var tuple1 = (10, "Code", 'X', "Dev", 9999999999999999999);
//        var tuple2 = (10, "Code", 'X', "Dev", 9999999999999999999);

//        Console.WriteLine(" Сравнение кортежей:");
//        Console.WriteLine($"tuple1 == tuple2: {tuple1 == tuple2}");
//        Console.WriteLine($"tuple1 != personInfo: {tuple1 != personInfo}");
//    }
//}






//5
//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 12, 45, 7, 89, 23 };
//        string phrase = "Щербет";

//        // Вызов локальной функции
//        var result = AnalyzeArray(numbers, phrase);

//        // Вывод результата
//        Console.WriteLine(" Результаты анализа:");
//        Console.WriteLine($"Максимум: {result.max}");
//        Console.WriteLine($"Минимум: {result.min}");
//        Console.WriteLine($"Сумма: {result.sum}");
//        Console.WriteLine($"Первая буква строки: '{result.firstChar}'");

//        // Локальная функция внутри Main
//        (int max, int min, int sum, char firstChar) AnalyzeArray(int[] arr, string text)
//        {
//            int max = int.MinValue;
//            int min = int.MaxValue;
//            int sum = 0;

//            foreach (int num in arr)
//            {
//                if (num > max) max = num;
//                if (num < min) min = num;
//                sum += num;
//            }

//            char firstChar = string.IsNullOrEmpty(text) ? '_' : text[0];

//            return (max, min, sum, firstChar);
//        }
//    }
//}






//6
using System;

class Program
{
    static void Main()
    {
        // a. Определение двух локальных функций
        void CheckedOverflow()
        {
            try
            {
                checked
                {
                    int max = int.MaxValue;
                    int result = max + 1; // вызывает исключение
                    Console.WriteLine($"[checked] Результат: {result}");
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine($"[checked] Переполнение: {ex.Message}");
            }
        }

        void UncheckedOverflow()
        {
            unchecked
            {
                int max = int.MaxValue;
                int result = max + 1; // переполнение без исключения
                Console.WriteLine($"[unchecked] Результат: {result}");
            }
        }

        // c. Вызов функций
        CheckedOverflow();
        UncheckedOverflow();
    }
}