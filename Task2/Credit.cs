using System;

namespace Task2
{
    class Credit
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t Вибiр кредiту");
            Console.ResetColor();
            Console.Write("Введiть час взяття кредiту(в роках): ");
            double time;
            bool num = double.TryParse(Console.ReadLine(), out time);
            if (num == false)
            {
                Console.WriteLine("Помилка! Перевiрьте данi!");
            }
            else
            {
                if (time < 0)
                {
                    Console.WriteLine("Помилка! Перевiрьте данi!");
                }
                else
                {
                    Console.Write("Введiть розмiр кредiту(в $): ");
                    double size;
                    bool num2 = double.TryParse(Console.ReadLine(), out size);
                    if (num2 == false)
                    {
                        Console.WriteLine("Помилка! Перевiрьте данi!");
                    }
                    else
                    if (size < 0)
                    {
                        Console.WriteLine("Помилка! Перевiрьте данi!");
                    }
                    else
                    {
                        {
                            Console.Write("Введiть чи можно погасити кредiт до сроку (True/False): ");
                            bool e;
                            bool num3 = bool.TryParse(Console.ReadLine(), out e);
                            if (num3 == false)
                            {
                                Console.WriteLine("Помилка! Перевiрьте данi!");
                            }
                            else
                            {
                                Console.WriteLine("Результат пошуку кредiта за Вашим бажанням: ");
                                MonoBank mono = new MonoBank();
                                mono.SearchCredit(time, size, e);
                                PrivatBank privat = new PrivatBank();
                                privat.SearchCredit(time, size, e);
                                AgricoleBank agricole = new AgricoleBank();
                                agricole.SearchCredit(time, size, e);
                            }
                        }
                    }
                }
            
            }
        }
    }

}
