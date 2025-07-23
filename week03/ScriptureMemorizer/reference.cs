﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptureMemorizer
{
    internal class Reference
    {
        
        private string _book = "";
        private int _chapter = 0;
        private int _verse = 0;
        private int _endVerse = 0;

        public Reference(string book, int chapter, int verse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;

        }
        public Reference(string book, int chapter, int startVerse, int endVerse)
        {
            _book = book;
            _chapter = chapter;
            _verse = startVerse;
            _endVerse = endVerse;
        }

        public string GetDisplayText()
        {
            string text = _book + " " + _chapter.ToString() + ":" + _verse.ToString() + "-" + _endVerse.ToString();
            return text;
        }
    }
}
