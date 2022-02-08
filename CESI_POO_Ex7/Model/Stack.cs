using CESI_POO_Ex7.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESI_POO_Ex7.Model
{
    public class Stack<T>
    {
        private T[] Values;
        private int ItemNumber;
        private int Max;
        public Stack(int max)
        {
            if (max < 0)
                throw new ArgumentOutOfRangeException("max of array can't be < 1");

            Max = max;
            Values = new T[Max];
            ItemNumber = 0;
        }

        public void Push(T item)
        {
            if (ItemNumber >= Values.Length)
                throw new FullStackException();
            Values[ItemNumber] = item;
            ItemNumber++;
        }
        public T Pop()
        {
            if (ItemNumber < 1)
                throw new EmptyStackException();
            ItemNumber--;
            T value = Values[ItemNumber];
            Values[ItemNumber] = default;
            return value;
        }

        public int Count()
        {
            return ItemNumber;
        }

        public void Clear()
        {
            Values = new T[Max];
        }
    }
}
