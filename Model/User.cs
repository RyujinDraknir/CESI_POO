using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESI_POO.Model
{
    public class User
    {
        public string Name { get; set; }
        public string FirstName { get; set; }
        public Language Language { get; set; }
        public DateTime Date { get; set; }

        public User(string name, string firstName, Language language)
        {
            Name = name;
            FirstName = firstName;
            Language = language;
            Date = DateTime.UtcNow;
        }


        public void SetLanguage(Language language)
        {
            this.Language = language;
        }

        public void PrintUser()
        {
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            return "Name : " + Name
                + "\n" + "FirstName : " + FirstName
                + "\n" + "Language : " + Language.ToString()
                + "\n" + "Date : " + Date.ToString("HH:mm:ss dd/MM/yyyy");
        }
    }
}
