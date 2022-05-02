using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Text 
    {
        List<string> textes = new List<string>();

        public Text()
        {
            Console.Write("Створен новий текст: ");

        }

        public void CreateText(List<string> s )
        {
            foreach (var item in s)
            {
                textes.Add(item);
            }
        }

        public void ShowText()
        {
            foreach (var item in textes)
            {
                Console.Write(item + " ");
            }
        }

        public void AddText(string s)
        {
            Console.WriteLine("Текст доповнено");
            textes.Add(s);
        }
        public void HeaderOfText(string s)
        {
            Console.WriteLine("Заголовок створено!");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\t\t\t"+s);
            Console.ResetColor();
            ShowText();
        }

    }
}
