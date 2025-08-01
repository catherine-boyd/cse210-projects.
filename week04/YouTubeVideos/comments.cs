using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeVideos
{
    internal class Comments
    {

        string _name = "";
        string _text = "";


        public Comments(string name, string text)
        {
            _name = name;
            _text = text;
        }

        public string GetName()
        {
            return _name;
        }
        public string GetText()
        {
            return _text;
        }
    }
}