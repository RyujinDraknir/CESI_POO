using CESI_POO.Model;
using System;

namespace CESI_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Language frLanguage = new Language("Français", "fr");
            Language enLanguage = new Language("English", "en");
            User user = new User("MICHEL", "Ronaldo", frLanguage);

            user.PrintUser();
            user.SetLanguage(enLanguage);
            user.PrintUser();
        }
    }
}
