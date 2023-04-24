using System;

namespace Stroki_menu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] menuItems = new string[] { "1. МЧС (пожарная часть)", "2. Полиция", "3. Скорая медицинская помощь", "4. Аварийная газовая служба" };
            int selectedItemIndex = 0;
            bool isExiting = false;

            while (!isExiting)
            {
                Console.Clear();
                Console.WriteLine("Выберите специальную службу из списка:");
                for (int i = 0; i < menuItems.Length; i++)
                {
                    if (i == selectedItemIndex)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    Console.WriteLine(menuItems[i]);
                    Console.ResetColor();
                }

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        if (selectedItemIndex > 0)
                        {
                            selectedItemIndex--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (selectedItemIndex < menuItems.Length - 1)
                        {
                            selectedItemIndex++;
                        }
                        break;
                    case ConsoleKey.Enter:
                        Console.Clear();
                        Console.WriteLine($"Вы выбрали: {selectedItemIndex}");
                        Console.WriteLine("Нажмите любую клавишу для продолжения...");
                        Console.ReadKey();
                        break;
                    case ConsoleKey.Escape:
                        Console.Clear();
                        Console.WriteLine("Вы точно хотите выйти из меню? (y/n)");
                        keyInfo = Console.ReadKey();
                        if (keyInfo.KeyChar == 'y')
                        {
                            isExiting = true;
                        }
                        while (keyInfo.KeyChar != 'n')
                        {
                            Console.Clear();
                            Console.WriteLine("Вы точно хотите выйти из меню? (y/n)");
                            Console.ReadKey();
                            break;
                        }
                        break;
                }
            }
        }
    }
}
