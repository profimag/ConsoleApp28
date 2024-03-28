using System;

namespace ExpenseManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] expenseCategories = { "Продукты", "Транспорт", "Учеба", "Развлечения" };
            int budget;

            Console.WriteLine("Введите ваш бюджет:");
            while (!int.TryParse(Console.ReadLine(), out budget))
            {
                Console.WriteLine("Введите корректное значение:");
            }

            int balance = budget;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("1. Просмотреть категории расходов");
                Console.WriteLine("2. Добавить расход");
                Console.WriteLine("3. Просмотреть бюджет и остаток");
                Console.WriteLine("4. Выйти");

                int choice = int.Parse(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Категории расходов:");
                    for (int i = 0; i < expenseCategories.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {expenseCategories[i]}");
                    }
                    Console.ReadLine();
                }
                else if (choice == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Выберите категорию расхода:");
                    for (int i = 0; i < expenseCategories.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {expenseCategories[i]}");
                    }
                    int categoryIndex = int.Parse(Console.ReadLine()) - 1;

                    Console.WriteLine("Введите сумму расхода:");
                    int amount;
                    while (!int.TryParse(Console.ReadLine(), out amount))
                    {
                        Console.WriteLine("Введите корректное значение:");
                    }

                    balance -= amount;

                    Console.WriteLine($"Расход на категорию {expenseCategories[categoryIndex]} добавлен. Остаток: {balance}");
                    Console.ReadLine();
                }
                else if (choice == 3)
                {
                    Console.Clear();
                    Console.WriteLine($"Бюджет: {budget}");
                    Console.WriteLine($"Остаток: {balance}");
                    Console.ReadLine();
                }
                else if (choice == 4)
                {
                    break;
                }
            }
        }
    }
}
