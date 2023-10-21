namespace PractosNumber5
{
    internal class SubClass
    {
        static string[] forma = new string[4] { "  Круглый - 100;", "  Квадратный- 250;", "  Ромб - 700;", "  Звезда- 500;" };
        static string[] size = new string[3] { "  Маленький - 300;", "  Средний - 500;", "  Большой- 600;"};
        static string[] vkus = new string[3] { "  Шоколадный - 250;", "  Ореховый - 650;", "  Апельсиновый - 500;" };
        static string[] Korgey = new string[3] { "  Один - 100;", "  Два - 200;", "  Три - 300;"};
        static string[] glazur = new string[3] { "  Шоколад - 200;", "  Драже - 150;", "  Ягоды - 400;" };
        static string[] decor = new string[3] {  "  Сироп - 200;", "  Карамель - 150;", "  Шоколад - 200;" };
        private static int cost;
        private static string? text;
        public static int x = 0;
        public static string y = "";
        private static DateTime date;

        public static int fixedPosition;
        private static int mainMenuPosition;

        public static int DO(int menu, int position, int x, string y, int maxposition, int minposition, ConsoleKey key, DateTime date)
        {
            maxposition = 9;
            minposition = 3;
            bool check = true;
            do
            {
                switch (menu)
                {
                    case 1:
                        Program.Menu(x, y);
                        break;
                    case 2:
                        Console.Clear();
                        SubMenu(menu, key, position, maxposition, minposition);
                        break;
                    case 3:
                        Console.Clear();
                        SubMenu(menu, key, position, maxposition, minposition);
                        break;
                    case 4:
                        Console.Clear();
                        SubMenu(menu, key, position, maxposition, minposition);
                        break;
                    case 5:
                        Console.Clear();
                        SubMenu(menu, key, position, maxposition, minposition);
                        break;
                    case 6:
                        Console.Clear();
                        SubMenu(menu, key, position, maxposition, minposition);
                        break;
                    case 7:
                        Console.Clear();
                        SubMenu(menu, key, position, maxposition, minposition);
                        break;
                }
                Program.WriteCursor(position);
                key = Console.ReadKey().Key;
                position = Program.CursorPosition(position, maxposition, minposition, key);
                if (key == ConsoleKey.Backspace)
                {
                    Console.Clear();
                }
                switch (menu)
                {
                    case 1:
                        switch (key)
                        {
                            case ConsoleKey.Enter:
                                switch (position)
                                {
                                    case 3:
                                        position = 0;
                                        minposition = 0;
                                        maxposition = 4;
                                        menu = 2;
                                        break;
                                    case 4:
                                        position = 0;
                                        minposition = 0;
                                        maxposition = 4;
                                        menu = 3;
                                        break;
                                    case 5:
                                        position = 0;
                                        minposition = 0;
                                        maxposition = 4;
                                        menu = 4;
                                        break;
                                    case 6:
                                        position = 0;
                                        minposition = 0;
                                        maxposition = 4;
                                        menu = 5;
                                        break;
                                    case 7:
                                        position = 0;
                                        minposition = 0;
                                        maxposition = 4;
                                        menu = 6;
                                        break;
                                    case 8:
                                        position = 0;
                                        minposition = 0;
                                        maxposition = 4;
                                        menu = 7;
                                        break;
                                    case 9:
                                        date = DateTime.Now;
                                        Console.Clear();
                                        Console.WriteLine("Заказ оформлен\r\n");
                                        File.AppendAllText("C:\\Users\\Dmitrii Tihonov\\Desktop\\История заказов.txt", $"Время заказа {date} \r \n Цена: {x}\r\n Состав заказа: {y}\r\n");
                                        x = 0;
                                        y = "";
                                        SubClass.x = 0;
                                        SubClass.y = "";
                                        break;
                                }
                                break;
                            case ConsoleKey.Escape:
                                Console.Clear();
                                check = false;
                                Environment.Exit(0);
                                break;
                        }
                        break;
                }
            } while (check);
            return menu;
        }
        private static void SubMenu(int menu, ConsoleKey key, int position, int maxposition, int minposition)
        {
            cost = 0;
            text = "";
            bool check = true;
            do
            {
                switch (menu)
                {
                    case 2:
                        Console.WriteLine(forma[0]);
                        Console.WriteLine(forma[1]);
                        Console.WriteLine(forma[2]);
                        Console.WriteLine(forma[3]);
                        Program.WriteCursor(position);
                        key = Console.ReadKey().Key;
                        position = Program.CursorPosition(position, maxposition, minposition, key);
                        switch (key)
                        {
                            case ConsoleKey.Enter:
                                switch (position)
                                {
                                    case 0:
                                        text = forma[0];
                                        cost = 100;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 1:
                                        text = forma[1];
                                        cost = 200;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 2:
                                        text = forma[2];
                                        cost = 300;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 4:
                                        text = forma[3];
                                        cost = 400;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                }
                                break;
                            case ConsoleKey.Escape:
                                position = 3;
                                Console.Clear();
                                menu = 1;
                                DO(menu, position, x, y, maxposition, minposition, key, date);
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine(size[0]);
                        Console.WriteLine(size[1]);
                        Console.WriteLine(size[2]);
                        Program.WriteCursor(position);
                        key = Console.ReadKey().Key;
                        position = Program.CursorPosition(position, maxposition, minposition, key);
                        switch (key)
                        {
                            case ConsoleKey.Enter:
                                switch (position)
                                {
                                    case 0:
                                        text = size[0];
                                        cost = 300;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 1:
                                        text = size[1];
                                        cost = 450;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 2:
                                        text = size[2];
                                        cost = 600;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                }
                                break;
                            case ConsoleKey.Escape:
                                position = 4;
                                Console.Clear();
                                menu = 1;
                                DO(menu, position, x, y, maxposition, minposition, key, date);
                                break;
                        }
                        break;
                    case 4:
                        Console.WriteLine(vkus[0]);
                        Console.WriteLine(vkus[1]);
                        Console.WriteLine(vkus[2]);
                        Program.WriteCursor(position);
                        key = Console.ReadKey().Key;
                        position = Program.CursorPosition(position, maxposition, minposition, key);
                        switch (key)
                        {
                            case ConsoleKey.Enter:
                                switch (position)
                                {
                                    case 0:
                                        text = vkus[0];
                                        cost = 300;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 1:
                                        text = vkus[1];
                                        cost = 400;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 2:
                                        text = vkus[2];
                                        cost = 200;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                }
                                break;
                            case ConsoleKey.Escape:
                                position = 5;
                                Console.Clear();
                                menu = 1;
                                DO(menu, position, x, y, maxposition, minposition, key, date);
                                break;
                        }
                        break;
                    case 5:
                        Console.WriteLine(Korgey[0]);
                        Console.WriteLine(Korgey[1]);
                        Console.WriteLine(Korgey[2]);
                        Program.WriteCursor(position);
                        key = Console.ReadKey().Key;
                        position = Program.CursorPosition(position, maxposition, minposition, key);
                        switch (key)
                        {
                            case ConsoleKey.Enter:
                                switch (position)
                                {
                                    case 0:
                                        text = Korgey[0];
                                        cost = 100;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 1:
                                        text = Korgey[1];
                                        cost = 200;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 2:
                                        text = Korgey[2];
                                        cost = 300;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                }
                                break;
                            case ConsoleKey.Escape:
                                position = 6;
                                Console.Clear();
                                menu = 1;
                                DO(menu, position, x, y, maxposition, minposition, key, date);
                                break;
                        }
                        break;
                    case 6:
                        Console.WriteLine(glazur[0]);
                        Console.WriteLine(glazur[1]);
                        Console.WriteLine(glazur[2]);
                        Program.WriteCursor(position);
                        key = Console.ReadKey().Key;
                        position = Program.CursorPosition(position, maxposition, minposition, key);
                        switch (key)
                        {
                            case ConsoleKey.Enter:
                                switch (position)
                                {
                                    case 0:
                                        text = glazur[0];
                                        cost = 200;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 1:
                                        text = glazur[1];
                                        cost = 200;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 2:
                                        text = glazur[2];
                                        cost = 300;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                }
                                break;
                            case ConsoleKey.Escape:
                                position = 7;
                                Console.Clear();
                                menu = 1;
                                DO(menu, position, x, y, maxposition, minposition, key, date);
                                break;
                        }
                        break;
                    case 7:
                        Console.WriteLine(decor[0]);
                        Console.WriteLine(decor[1]);
                        Console.WriteLine(decor[2]);
                        Program.WriteCursor(position);
                        key = Console.ReadKey().Key;
                        position = Program.CursorPosition(position, maxposition, minposition, key);
                        switch (key)
                        {
                            case ConsoleKey.Enter:
                                switch (position)
                                {
                                    case 0:
                                        text = decor[0];
                                        cost = 500;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 1:
                                        text = decor[1];
                                        cost = 300;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                    case 2:
                                        text = decor[2];
                                        cost = 200;
                                        position = 8;
                                        Returned(menu, position, maxposition, minposition, key, date);
                                        break;
                                }
                                break;
                            case ConsoleKey.Escape:
                                check = false;  // Зафиксирована 
                                mainMenuPosition = position;  // Запоминаем 
                                position = mainMenuPosition; 
                                break;
                        }
                        break;
                }
            } while (check);
        }
        private static int Cost()
        {
            x = x + cost;
            return x;
        }
        private static string Text()
        {
            y = y + text;
            return y;
        }
        private static void Returned(int menu, int position, int maxposition, int minposition, ConsoleKey key, DateTime date)
        {
            Cost();
            Text();
            position = 3;
            Console.Clear();
            menu = 1;
            DO(menu, position, x, y, maxposition, minposition, key, date);
        }

    }
}