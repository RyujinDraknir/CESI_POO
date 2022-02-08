using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESI_POO_Ex5.Model
{
    public abstract class Fruit
    {
        public string Color { get; set; }
        public Fruit() { }
        public Fruit(string color)
        {
            Color = color;
        }
        public abstract void Eat();

        
    }
}
