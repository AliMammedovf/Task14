using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Books
    {
        public int No { get; set; }

        private static int _no = 0;

        public string Name { get; set; }

        public string AuthorName { get; set; }

       private int _pageCount { get; set; }
        public Books(string name, string authorname, int pageCount)
        {
            _no++;
            No = _no;
            Name = name;
            AuthorName = authorname;
            _pageCount = pageCount;

        }
            
        public int PageCount
        {
            get
            {
                return _pageCount;
            }
            set
            {
                if(value > 0)
                {
                    _pageCount = value;
                }
            }
        }

        public Books() 
        {
            
        }

        public override string ToString()

        {
            return $" No:{No}\n Name:{Name}\n Author:{AuthorName}\n PageCount:{PageCount}";

        }
    }
}
