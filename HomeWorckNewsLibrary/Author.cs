using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorckNewsLibrary
{
    public class Author
    {
        private string _name;

        public Author(string name)
        {
            _name = name;
        }

        public Article WriteArticle(string title, string content)
        {
            Article article = new Article(title, content, this);

            return article;
        }
    }
}
