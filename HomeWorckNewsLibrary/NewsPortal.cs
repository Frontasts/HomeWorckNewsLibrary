using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorckNewsLibrary
{
    public class NewsPortal
    {
        private string _name;
        private List<Article> _articles;

        public NewsPortal(string name)
        {
            _name = name;
            _articles = new List<Article>();
        }
    }
}
