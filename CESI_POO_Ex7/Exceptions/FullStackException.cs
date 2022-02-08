using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CESI_POO_Ex7.Exceptions
{
    public class FullStackException : Exception
    {
        public FullStackException()
        {
        }

        public FullStackException(string message) 
            : base("FullStackException.Message : Stack is Full" + message)
        {
        }
    }
}
