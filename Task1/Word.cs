using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    class Word
    {
        private string word;
        public string _Word
        {
            get { return word; }
            set { word = value; }
        }
        public Word(string word)
        {
            
            this.word = word;
            Console.WriteLine($"Створено нове слово: {word}"); ;
        }

        public override string ToString()
        {
            return $"Слово: {word} ";
        }
        public override bool Equals(object obj)
        {
            if (obj == word)
                return true;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return word.GetHashCode();
        }

    }
}
