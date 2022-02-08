using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESI_POO_Ex4.Model
{
    public class Author
    {
        public string Name { get; private set; }
        public string EMail { get; private set; }

        public Author(string name, string eMail)
        {
            Name = name;
            EMail = eMail;
        }
        public string ToString(int tabulationNumber = 0)
        {
            string tabBefore = "";
            if(tabulationNumber > 0)
            {
                for (int i = 0; i < tabulationNumber; i++)
                {
                    tabBefore += "\t";
                }
            }

            return tabBefore + "Name : " + Name
                + "\n" + tabBefore + "EMail : " + EMail;
        }
    }
}
