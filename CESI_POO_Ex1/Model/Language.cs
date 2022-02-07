using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESI_POO.Model
{
    public class Language
    {
        public string Name { get; set; }
        public string CharCode { get; set; }
        public Language(string name, string charCode)
        {
            Name = name;
            CharCode = charCode;
        }

        public override string ToString()
        {
            return "\n\t" + "Name : " + Name
                + "\n\t" + "CharCode : " + CharCode;
        }
    }
}
