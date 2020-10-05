using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LR2
{
    class Program
    {

        public static void Checked(int check)
        {
            check = checked(check + 1);
            Console.WriteLine($"Выведем переменную с проверенным контекстом: {check}");
        }

        public static void Unchecked(int uncheck)
        {
            uncheck = unchecked(uncheck + 1);
            Console.WriteLine($"Выведем переменную с непроверенным контекстом: {uncheck}");
        }

        public static (int, int, int, string) Math(int[] x, string str)
        {
            int min = x[0];
            int max = x[0];
            int sum = x[0];
            string s = str.Substring(0, 1);

            for (int i = 1; i < x.Length; i++)
            {
                if (x[i] > max) max = x[i];
                if (x[i] < min) min = x[i];
                sum += x[i];
            }
            return (min, max, sum, s);
        }
        public static int menu()
        {
            // Выбранный вариант менюж
            int variant;
            Console.WriteLine("Выберите вариант\n");
            Console.WriteLine("1. Типы данных\n");
            Console.WriteLine("2. Строки\n");
            Console.WriteLine("3. Массивы\n");
            Console.WriteLine("4. Кортежи\n");
            Console.WriteLine("5. Функция\n");
            Console.WriteLine("6. Две локальные функции\n");
            Console.WriteLine("7. выйти\n");
            variant = int.Parse(Console.ReadLine());
            return variant;
        }
        public static void TypesData(int variant)
        {
            int myint, testobject;
            bool mybool;
            double mydouble;
            string mystring;
            byte mybyte;
            uint myuint;
            short myshort;
            ushort myushort;
            long mylong;
            ulong myulong;
            char mychar;
            object myobject;
            Console.WriteLine("Продемонстрируем работу типа данных int");
            myint = int.Parse(Console.ReadLine());
            Console.WriteLine("Продемонстрируем работу типа данных bool");
            mybool = bool.Parse(Console.ReadLine());
            Console.WriteLine("Продемонстрируем работу типа данных double");
            mydouble = double.Parse(Console.ReadLine());
            Console.WriteLine("Продемонстрируем работу типа данных string");
            mystring = Console.ReadLine();
            Console.WriteLine("Продемонстрируем работу типа данных byte");
            mybyte = byte.Parse(Console.ReadLine());
            Console.WriteLine("Продемонстрируем работу типа данных uint");
            myuint = uint.Parse(Console.ReadLine());
            Console.WriteLine("Продемонстрируем работу типа данных short");
            myshort = short.Parse(Console.ReadLine());
            Console.WriteLine("Продемонстрируем работу типа данных ushort");
            myushort = ushort.Parse(Console.ReadLine());
            Console.WriteLine("Продемонстрируем работу типа данных long");
            mylong = long.Parse(Console.ReadLine());
            Console.WriteLine("Продемонстрируем работу типа данных ulong");
            myulong = ulong.Parse(Console.ReadLine());
            Console.WriteLine("Продемонстрируем работу типа данных char");
            mychar = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Продемонстрируем работу типа данных object");
            testobject = int.Parse(Console.ReadLine());
            myobject = testobject;
            Console.WriteLine("==================================================================");
            Console.WriteLine("Явные не явные преобразования");
            myshort = (short)myint;
            Console.WriteLine("Явное преобразование int в short: {0}", myint);
            mybyte = (byte)myuint;
            Console.WriteLine("Явное преобразование uint в byte: {0}", mybyte);
            mychar = (char)mydouble;
            Console.WriteLine("Явное преобразование double в char: {0}", mychar);
            mylong = (long)myulong;
            Console.WriteLine("Явное преобразование ulong в long: {0}", mylong);
            myushort = (ushort)myulong;
            Console.WriteLine("Явное преобразование ulong в ushort: {0}", myushort);
            myint = 1;
            mylong = myint;
            mybool = true;
            myobject = mychar;
            mystring = "string";
            Console.WriteLine("Неявные преобразования: {0}, {1}, {2}, {3}, {4}, {5}", myint, mylong, mybool, myobject, mystring);
            Console.WriteLine("==================================================================");
            Console.WriteLine("Работа с Nullable переменными");
            int? nullint = 1;
            System.Nullable<double> nulldouble = 5.6456;
            Console.WriteLine("Проверка Nullable переменных на наличие значений");
            if ((nullint.HasValue)&&(nulldouble.HasValue))
            {
                Console.WriteLine("Вывод Nullable переменных: {0}, {1}", nullint.Value, nulldouble.HasValue);
            }
            else
            {
                if (nullint.HasValue)
                {
                    Console.WriteLine("Вывод Nullable переменной nullint: {0}", nullint.Value);
                }
                if (nulldouble.HasValue)
                {
                    Console.WriteLine("Вывод Nullable переменной nullbouble: {0}", nulldouble.HasValue);
                }
            }
            Console.WriteLine("==================================================================");
            Console.WriteLine("Работа с переменной var");
            var myvar = 03042002;
            //myvar = "03.04.2002"
            Program.Main();
        }
        public static void MyStrings(int variant)
        {
            Console.WriteLine("Работа с литералами строк");
            Console.WriteLine("Hello");
            Console.WriteLine("World");
            string mystring1 = "Hello";
            string mystring2 = "world!";
            int result = String.Compare(mystring1, mystring2);
            if (result < 0)
            {
                Console.WriteLine("Первая строка стоит по алфавиту выше второй");
            }
            else
            {
                Console.WriteLine("Вторая строка стоит по алфавиту выше первой");

            }
            Console.WriteLine(result);
            Console.WriteLine("==================================================================");
            string stroka1, stroka2, stroka3;
            Console.WriteLine("Заполним переменные...");
            stroka1 = Console.ReadLine();
            stroka2 = Console.ReadLine();
            stroka3 = Console.ReadLine();
            Console.WriteLine("Выведем значение переменных: {0}, {1}, {2} . Приступим к действиям над строками...", stroka1, stroka2, stroka3);
            Console.WriteLine("==================================================================");
            string resultconcat = stroka1 + " " + stroka2;
            resultconcat = String.Concat(resultconcat, "!");
            Console.WriteLine("Результат сцепления строк: {0}", resultconcat);
            stroka3 = String.Copy(stroka1);
            Console.WriteLine("Вывод строки оригинала: {0}", stroka1);
            Console.WriteLine("Вывод строки-копии: {0}", stroka3);
            stroka3 = stroka2.Substring(0, 3);
            Console.WriteLine("Из строки {0} выделена подстрока {1}", stroka2, stroka3);
            string[] words = resultconcat.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine("Результат разделения строк: {0}, {1}", words[0], words[1]);
            stroka3 = stroka2.Insert(0, stroka1);
            Console.WriteLine("Результат вставки строки в другую: {0}", stroka3);
            int index = stroka1.Length;
            stroka3 = stroka3.Remove(index);
            Console.WriteLine("Результат удаления подстроки: {0}", stroka3);
            int first = 8;
            int second = 7;
            string interp = $"{first} + {second} = {first + second}";
            Console.WriteLine("Результат интерполяции: {0}", interp);
            Console.WriteLine("==================================================================");
            string nullstring = null;
            string emptystring = "";
            string commonstring = "1";
            bool metod1 = String.IsNullOrEmpty(nullstring);
            bool metod2 = String.IsNullOrEmpty(emptystring);
            bool metod3 = String.IsNullOrEmpty(commonstring);
            Console.WriteLine("Результат проверки строк: {0}, {1}, {2}", metod1, metod2, metod3);
            string spacestring = "1 2";
            metod2 = String.IsNullOrEmpty(spacestring);
            Console.WriteLine("Результат проверки строки на пробелы: {0}", metod2);
            Console.WriteLine("==================================================================");
            StringBuilder stringBuilder = new StringBuilder("ello worldd");
            Console.WriteLine($"Выведем полученную строку: {stringBuilder}");
            Console.WriteLine($"Длина строки: {stringBuilder.Length}");
            Console.WriteLine($"Емкость строки: {stringBuilder.Length}");
            stringBuilder.Insert(0, "h");
            stringBuilder.Remove(10, 1);
            Console.WriteLine($"Выведем результат редактирования строки: {stringBuilder}");
            Program.Main();
        }

        public static void Massives(int variant) {
            Console.WriteLine("Создадим двумерный массив");
            int n = 3;
            int m = 3;
            int[,] matrix = new int[n,m];
            int index = 0;
            Console.WriteLine("Заполним и выведем массив");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    index = int.Parse(Console.ReadLine());
                    matrix[i, j] = index;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("==================================================================");
            string[] stringsmassive = { "String", "Massive", "s"};
            for (int  i = 0;  i < stringsmassive.Length;  i++)
            {
                Console.WriteLine($"stringsmassive[{i}]= {stringsmassive[i]}");
            }
            Console.Write("Введите номер строки которую хотите изменить - ");
            int position = int.Parse(Console.ReadLine());
            for (int i = 0; i < stringsmassive.Length; i++)
            {
                if (position == i + 1)
                {
                    string str = Console.ReadLine();
                    stringsmassive[i] = str;
                }
            }
            Console.WriteLine("Выведем отредактированный массив строк");
            for (int i = 0; i < stringsmassive.Length; i++)
            {
                Console.WriteLine($"stringsmassive[{i}]= {stringsmassive[i]}");
            }
            Console.WriteLine("==================================================================");
            int pos;
            int[][] stupmass = new int[3][];
            stupmass[0] = new int[2] { 0, 0 };
            stupmass[1] = new int[3] { 0, 0, 0 };
            stupmass[2] = new int[4] { 0, 0, 0, 0 };
            Console.WriteLine("Введем данные и выведем массив");
            for (int k = 0; k < stupmass.Length; k++)
            {
                for (int c = 0; c < stupmass[k].Length; c++)
                {
                    pos = int.Parse(Console.ReadLine());
                    stupmass[k][c] = Convert.ToInt32(pos);
                }
                Console.WriteLine();
            }
            for (int k = 0; k < stupmass.Length; k++)
            {
                for (int c = 0; c < stupmass[k].Length; c++)
                {
                    Console.Write($"{stupmass[k][c]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("==================================================================");
            var varmassive = new[] { 1, 2, 3 };
            var varstring = "asdasd";
            Program.Main();
        }
        public static void Kortej(int variant)
        {
            (int first, string second, char third, string fourth, ulong fifth) mykortej = (10, "hello", 'G', "kortej", 14323412);
            Console.WriteLine($"Выведем весь кортеж: {mykortej.first}, {mykortej.second}, {mykortej.third}, {mykortej.fourth}, {mykortej.fifth}");
            Console.WriteLine("==================================================================");
            Console.WriteLine("Введем номера элементов кортежа которые хотим вывести");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            if ((x == 1)&&(y == 1)&&(z == 1))
            {
                Console.WriteLine($"1. {mykortej.first}");
            }
            if ((x == 2) && (y == 2) && (z == 2))
            {
                Console.WriteLine($"2. {mykortej.second}");
            }
            if ((x == 3) && (y == 3) && (z == 3))
            {
                Console.WriteLine($"3. {mykortej.third}");
            }
            if ((x == 4) && (y == 4) && (z == 4))
            {
                Console.WriteLine($"4. {mykortej.fourth}");
            }
            if ((x == 5) && (y == 5) && (z == 5))
            {
                Console.WriteLine($"5. {mykortej.fifth}");
            }
            Console.WriteLine("==================================================================");
            Console.WriteLine("Сделаем распаковку кортежа в переменные");
            var first = mykortej.first;
            var second = mykortej.second;
            var third = mykortej.third;
            var fourth = mykortej.fourth;
            var fifth = mykortej.fifth;
            Console.WriteLine("==================================================================");

            Console.WriteLine("==================================================================");
            (int, int) kortej1 = (1, 1);
            (int, int) kortej2 = (1, 1);
            Console.WriteLine("Сравнение кортежей...");
            if (kortej1.Item1 == kortej2.Item1 && kortej1.Item2 == kortej2.Item2)
            {
                Console.WriteLine("Кортежи равны");
            }
            else
            {
                Console.WriteLine("Кортежи не равны");
            }
            Program.Main();
        }

        public static void Function(int variant) {
            int[] massive = new[] { 2, 1, 3 };
            string newstring = "ABC";
            (int, int, int, string) kortej = Math(massive, newstring);
            Console.WriteLine($"Работа с локальной функцией: {kortej}");
            Program.Main();
        }

        public static void TwoFunctions(int variant)
        {
            int checks = 2147483647, unchecks = 2147483647;
            Program.Checked(checks);
            Program.Unchecked(unchecks);
            Program.Main();
        }

        static void Main()
        {

            int variant = menu();

            switch (variant)
            {
                case 1:
                    Console.WriteLine("Типы данных");
                    Program.TypesData(variant);
                    break;
                case 2:
                    Console.WriteLine("Строки");
                    Program.MyStrings(variant);
                    break;
                case 3:
                    Console.WriteLine("Массивы");
                    Program.Massives(variant);
                    break;
                case 4:
                    Console.WriteLine("Кортежи");
                    Program.Kortej(variant);
                    break;
                case 5:
                    Console.WriteLine("Функция");
                    Program.Function(variant);
                    break;
                case 6:
                    Console.WriteLine("Две локальные функции");
                    Program.TwoFunctions(variant);
                    break;
                case 7:
                    Console.WriteLine("Выход из программы...");
                    break;
            }
            
        }
    }

       
}
