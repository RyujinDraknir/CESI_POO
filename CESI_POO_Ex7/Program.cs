using CESI_POO_Ex7.Exceptions;
using CESI_POO_Ex7.Model;
using System;

namespace CESI_POO_Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack<int>(10);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Count());

            stack.Clear();
            try
            {
                stack.Pop();
            }
            catch (EmptyStackException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                for (int i = 0; i <= 10; i++)
                {
                    stack.Push(i);
                }
            }
            catch (FullStackException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
