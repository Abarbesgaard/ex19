using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Controller
    {
        private List<Book> books;
        private List<Amulet> amulets;
        public List<Book> Books
        {
            get { return books; }
            set { books = value; }
        }
        public List<Amulet> Amulets
        {
            get { return amulets; }
            set { amulets = value; }
        }
        public Controller()
        {
		Books = new List<Book>();  
        Amulets = new List<Amulet>();
        }
        public void AddToList(Book book) 
        {
             Books.Add(book);
        }
        public void AddToList(Amulet amulet) 
        { 
            Amulets.Add(amulet);
        }


	}
}
