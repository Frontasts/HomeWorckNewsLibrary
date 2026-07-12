using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorckNewsLibrary
{
    public class Article
    {
        private string _title;
        private string _content;
        private Author _author;
        private bool _isPublished;

        public Article(string title, string content, Author author)
        {
            _title = title;
            _content = content;
            _author = author;
            _isPublished = false;
        }

        public bool Publish()
        {
            if(_isPublished == false)
            {
                return false;
            }

            _isPublished = true;
            Console.WriteLine();
            Console.WriteLine($"Статья \"{_title}\" опубликована автором {_author}");
            return true;
        }
    }
}
