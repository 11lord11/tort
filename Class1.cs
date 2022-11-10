namespace торты
{
    internal class bb
    {
        private static int A;
        public static void AA(int aaaa)
        {
            A = aaaa;
        }
        private static string[] aa = new string[] { "  Квадрат", "  Круг", "  Сердце", "  Треугольник", "  Параллелограмм" };
        private static string[] ab = new string[] { "  Маленький", "  Средний", "  Большой" };
        private static string[] ac = new string[] { "  Шоколад", "  Ваниль", "  Безе" };
        private static string[] ad = new string[] { "  Один корж", "  Два коржа", "  Три коржа" };
        private static string[] af = new string[] { "  Шоколадная", "  Кремовая", "  Клубничная" };
        private static string[] ag = new string[] { "  Конфеты", "  Фигурки", "  Серпантинки" };
        private static int izncena;
        private static List<string> bc = new List<string> { };
        
        public static void yaebalsenuvrot(string a,int c)
        {
            string txt = "";
            for (int i = 0; i < bc.Count; i++)
            {
                txt += $"{bc[i]}\n";  
            }
            int pos = 2;
            Console.Clear();
            Console.WriteLine(a);
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("=>");
            Console.SetCursorPosition(0, 8);
            Console.WriteLine($"\nВаша итоговая цена: {izncena}");
            Console.SetCursorPosition(0, 10);
            Console.WriteLine($"Ваш торт:\n {txt}");

            ConsoleKeyInfo b;
            do
            {
                b = Console.ReadKey();
                switch (b.Key)
                {
                    case ConsoleKey.DownArrow:
                        pos++;
                        if (pos > c)
                        {
                            pos--;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        pos--;
                        if (pos < 2)
                        {
                            pos++;
                        }
                        break;
                }
                Console.Clear();
                Console.WriteLine(a);
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("=>");
                Console.SetCursorPosition(0, 8);
                Console.WriteLine($"\nВаша итоговая цена: {izncena}");
                Console.SetCursorPosition(0, 10);
                Console.WriteLine($"Ваш торт:\n {txt}");
            } while (b.Key != ConsoleKey.Enter);
            per(pos);
        }
        private static void per(int pos)
        {
            switch (pos)
            {

                case 2:
                    tt(aa, 6);
                    break;
                case 3:
                    tt(ab, 4);
                    break;
                case 4:
                    tt(ac, 4);
                    break;
                case 5:
                    tt(ad, 4);
                    break;
                case 6:
                    tt(af, 4);
                    break;
                case 7:
                    tt(ag, 4);
                    break;
                case 8:
                    switch (A)
                    {
                        case 1:
                            string bcf = "";
                            for (int i = 0; i < bc.Count; i++)
                            {
                                bcf = bcf + $"{bc[i]}\n";
                            }
                            File.WriteAllText("C:\\Users\\User\\OneDrive\\Рабочий стол\\Заказы.txt", $"Ваши заказы:\n\nТорт, который состоит из:\n{bcf}\nНа цену: {izncena}");
                            break;
                        case 2:
                            bcf = "";
                            for (int i = 0; i < bc.Count; i++)
                            {
                                bcf = bcf + $"{bc[i]}\n";
                            }
                            File.AppendAllText("C:\\Users\\User\\OneDrive\\Рабочий стол\\Заказы.txt", $"\n\nТорт, который состоит из:\n{bcf}\nНа цену: {izncena}");
                            break;
                    }
                    break;
            }

        }
        public static void tt(string[] a,int bb)
        {
            int pos = 2;
            Console.Clear();
            int cena = 300;
            Console.WriteLine($"Выберите из меню\n --------------"); ;
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
                Console.SetCursorPosition(18, i + 2);
                Console.WriteLine(cena);
            }

            Console.SetCursorPosition(0, pos);
            Console.WriteLine("=>");
            ConsoleKeyInfo b;
            do
            {
                b = Console.ReadKey();
                switch (b.Key)
                {
                    case ConsoleKey.DownArrow:
                        pos++;
                        if (pos > bb)
                        {
                            pos--;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        pos--;
                        if (pos < 2)
                        {
                            pos++;
                        }
                        break;
                }
                Console.Clear();
                Console.WriteLine($"Выберите из меню\n --------------"); ;
                for (int i = 0; i < a.Length; i++)
                {
                    Console.WriteLine(a[i]);
                    Console.SetCursorPosition(18, i + 2);
                    Console.WriteLine(cena);
                }
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("=>");
            } while (b.Key != ConsoleKey.Enter);
            bc.Add(a[pos - 2]);
            izncena += cena;
            yaebalsenuvrot("Выберите параметр торта\n" +
       "----------------------------------\n" +
            "  Форма\n" +
            "  Размер\n" +
            "  Вкус коржей\n" +
            "  Количество коржей\n" +
            "  Глазурь\n" +
            "  Декор\n" +
            "  Конец заказа", 8);
        }
        public static void och()
        {
            izncena = 0;
            bc.Clear();
        }
    }
}
