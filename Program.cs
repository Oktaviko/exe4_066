using System;
using System.Collections.Generic;
using System.ComponentModel;
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
                Console.WriteLine("Stack Underflow");
                return -1;
            }
            else
            {
                Console.WriteLine("Element yang terhapus adalah :" + okta[top]);
                top--;
                return top;
            }
        }
        public void push()
        {
            if(top == max -1)
            {
                Console.WriteLine("Stack Overflow");
                return;
            }
            else
            {
                top++;
                Console.WriteLine("Masukkan Element : ");
                okta[top] = Console.ReadLine();
            }
        }
        public void display()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
                return ;
            }
            else
            {
                for (int i = 0;i <= top;i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]: " + okta[i]);
                }
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
