using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeVideos
{
    internal class Video
    {

        private string _title = "";
        private string _author = "";
        private int _length = 0;
        private List<Comments> _comments;

        public string GetTitle()
        {
            return _title;
        }
        public string GetAuthor()
        {
            return _author;
        }
        public int GetLength()
        {
            return _length;
        }
        public int GetCommentLength()
        {
            return _comments.Count;
        }

        public List<Comments> GetComments()
        {
            return _comments.ToList();
        }
        public Video(string author, List<Comments> comments, int length, string title)
        {
            _author = author;
            _length = length;
            _comments = comments;
            _title = title;
        }
        public int Length()
        {
            return _length;
        }
    }
}