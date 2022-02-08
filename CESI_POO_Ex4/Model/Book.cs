using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESI_POO_Ex4.Model
{
    public class Book
    {
        public string Name { get; private set; }
        public int Price { get; private set; }
        public List<Author> Authors { get; private set; }
        public Book(string name, int price)
        {
            Name = name;
            Price = price;
            Authors = new List<Author>();
        }

        public override string ToString()
        {
            string toString = "Name : " + Name
                + "\n" + "Price : " + Price
                + "\n" + "Authors : ";

            foreach(Author a in Authors)
            {
                toString += "\n" + a.ToString(1);
            }

            return toString;
        }
    }
}
