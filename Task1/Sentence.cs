using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Sentence
    {
        public List<string> sentences = new List<string>();

        public Sentence()
        {
            Console.Write("Створено нове речення: ");
            
        }

        public void CreateSentence(Word word)
        {
            sentences.Add(word._Word);
           
           
        }

        public void PrintS()
        {
            foreach (var item in sentences)
            {
                Console.Write(item + " ");
            }
        }

    }
}
