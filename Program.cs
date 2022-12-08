using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exe4_066
{
    class Stack
    {
        private string[] okta = new string[85];
        private int top;
        private int max;
        public Stack()
        {
            top = -1;
            max = okta.Length;
        }
        public int pop()
        {
            if(top == -1)
            {
                Console.WriteLine("Stack Under");
                return -1;
            }
            else
            {
                Console.WriteLine("Element yang terhapus adalah :" + okta[top]);
                top--;
                return top;
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
