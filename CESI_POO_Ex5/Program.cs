using CESI_POO_Ex5.Model;
using System;

namespace CESI_POO_Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            //var fruit = new Fruit();
            var orange = new Orange("orange");
            orange.Eat();
            var strawberry = new Strawberry();
            strawberry.Eat();
        }
    }
}
