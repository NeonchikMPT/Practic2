bool Stop = false;
int operation;
double a;
double b;
while (Stop == false)
{
    Console.WriteLine("");
    Console.WriteLine("Угадай число - 1");
    Console.WriteLine("Таблица умножения - 2");
    Console.WriteLine("Вывод делителей числа - 3");
    Console.WriteLine("Выход из программы - 4");
    operation = Convert.ToInt32(Console.ReadLine());
    switch (operation)
    {
        case 1:
            {
                Console.WriteLine("Угадайте число от 0 до 100");
                Random ran = new Random();
                int value = ran.Next(0, 100);
                int c = 0;
                Console.WriteLine("Вставьте число ");
                do
                {
                    b = Convert.ToInt32(Console.ReadLine());
                    if (b < value)
                        Console.WriteLine("Число больше");
                    if (b > value)
                        Console.WriteLine("Число меньше");
                    c++;
                } while (b != value);
                Console.WriteLine("Молодец, ты угадал!");

            }
            break;
        case 2:
            {
                for (int i = 2; i <= 9; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.Write(i * j + "\t");
                    }
                    Console.WriteLine("\r\n");
                }
                break;
            }
        case 3:
            {
                Console.WriteLine("Введите число: ");
                int numb = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i < numb; i++)
                {
                    if (numb % i == 0)
                        Console.Write(i + "\t");
                }
                break;
            }
        case 4:
            {
                Environment.Exit(0);
                break;
            }
    }
}