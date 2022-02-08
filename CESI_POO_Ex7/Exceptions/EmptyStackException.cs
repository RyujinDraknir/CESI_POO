using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESI_POO_Ex7.Exceptions
{
    public class EmptyStackException : Exception
    {
        public EmptyStackException()
        {
        }

        public EmptyStackException(string message)
            : base("EmptyStackException.Message : Stack is Empty" + message)
        {
        }
    }
}
