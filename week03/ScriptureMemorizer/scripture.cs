using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        private Reference _reference;
        private List<Word> _words;
        private static Random _random = new Random();

        public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = new List<Word>();

            // Split text into words and create Word objects
            foreach (string word in text.Split(' '))
            {
                _words.Add(new Word(word));
            }
        }

        public void HideRandomWords(int count = 3)
        {
            for (int i = 0; i < count; i++)
            {
                int index = _random.Next(_words.Count);
                _words[index].Hide();
            }
        }

        public string GetDisplayText()
        {
            List<string> displayWords = new List<string>();
            foreach (Word word in _words)
            {
                displayWords.Add(word.GetDisplayText());
            }
            return $"{_reference.GetDisplayText()} - {string.Join(" ", displayWords)}";
        }

        public bool IsCompletelyHidden()
        {
            foreach (Word word in _words)
            {
                if (!word.IsHidden())
                    return false;
            }
            return true;
        }
    }
}
