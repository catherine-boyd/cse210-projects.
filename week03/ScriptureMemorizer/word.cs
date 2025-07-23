using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptureMemorizer
{
    internal class Word
    {
    private string _text = "";
        private bool _isHidden = false;

        public Word(string text)
        {
            _text = text;
        }

        public void Hide()
        {
            int wordLength = _text.Length;
            char[] text = _text.ToCharArray();
            for (int i = 0; i < wordLength; i++)
            {
                text[i] = '_';
            }
            _text = new string(text);
            _isHidden = true;
        }
        public void Show()
        {
            _isHidden = false;
        }
        public bool IsHidden()
        {
            return _isHidden;
        }
        public string GetDisplayText()
        {
            return _text;
        }
    }

}
