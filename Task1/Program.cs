using System;

namespace Task1
{
    class program
    {
        static void Main()
        {
            Word w1 = new Word("Слава");
            Word w2 = new Word("Українi");
            Word w3 = new Word("Героям ");
            Word w4 = new Word("Слава");
            Word w5 = new Word("!");

            Sentence s1 = new Sentence();
            s1.CreateSentence(w1);
            s1.CreateSentence(w2);
            s1.PrintS();
            Console.WriteLine();
            
            Sentence s2 = new Sentence();
            s2.CreateSentence(w3);
            s2.CreateSentence(w4);
            s2.CreateSentence(w5);
            s2.PrintS();
            Console.WriteLine();

            Text text = new Text();
            text.CreateText(s1.sentences);
            text.CreateText(s2.sentences);
            text.ShowText();
            Console.WriteLine();
            text.AddText("Слава нацiї, Смерть ворогам!");
            text.ShowText();
            Console.WriteLine();
            text.HeaderOfText("Смерть москальнi!");
            Console.WriteLine();

            
            

        }
    }
}
