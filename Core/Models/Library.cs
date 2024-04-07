using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core.Models
{
    public class Library
    {  
        public Library()
        {
            
        }


        Books[] Book=new Books[] { };

        

        public void AddBook(Books book)
        {
            Array.Resize(ref Book, Book.Length + 1);
            Book[Book.Length-1] = book;
        }

        public Books[] ShowAllBooks()
        {
            return Book;
            
        }

        public Books[] FindAllBooksByName(string value)
        {
            Books[] findName=new Books[] { };

            for (int i = 0; i < Book.Length; i++)
            {
                if (Book[i].Name.Contains(value))
                {
                    Array.Resize(ref findName, findName.Length+1);
                    findName[findName.Length-1] = Book[i];
                }
            }
            return findName;
        }
        public Books[] RemoveAllBooksByName(string value)
        {
            Books[] removeBooks=new Books[] { };

            for(int i = 0;i < Book.Length; i++)
            {
                if (!Book[i].Name.Contains(value))
                {
                    Array.Resize(ref  removeBooks, removeBooks.Length+1);
                    removeBooks[removeBooks.Length-1]= Book[i];

                }
            }
           Book=removeBooks;
            return removeBooks;
        }

        public Books[] SearchBooks(string value)
        {
            Books[] searchBooks=new Books[] { };


            for(int i=0; i < Book.Length; i++)
            {
                if (Book[i].Name.Contains(value) || Book[i].AuthorName.Contains(value) || Book[i].PageCount.ToString().Contains(value))
                {
                    Array.Resize(ref  searchBooks, searchBooks.Length+1);
                    searchBooks[searchBooks.Length-1]= Book[i];
                }
            }
            return searchBooks;
        }
    }
}
