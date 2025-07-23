using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScriptureMemorizer
{
    internal class Scripture
    {
            private Reference _reference;
            private List<Word> _words = new List<Word>();

            public Scripture(Reference reference, string text)
            {
                string[] words = text.Split(' ');

                foreach (string word in words)
                {
                    Word textWord = new Word(word);
                    _words.Add(textWord);
                }
                _reference = reference;

            }

            public void HideRandomWords(int numberToHide)
            {

                _words[numberToHide].Hide();
            }
            public string GetDisplayText()
            {
                string reference = _reference.GetDisplayText();
                string text = "";

                foreach (Word word in _words)
                {
                    text = text + " " + word.GetDisplayText();
                }
                return reference + " " + text;
            }
            public bool IsCompletelyHidden()
            {
                bool isCompletelyHidden = true;
                foreach (Word word in _words)
                {
                    if (!word.IsHidden())
                    {
                        isCompletelyHidden = false;
                        break;
                    }
                }
                return isCompletelyHidden;
            }
        }
    }

