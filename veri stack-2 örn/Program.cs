using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veri_stack_2_örn
{
    class Program
    {
        static int sp = -1;
        static int max = 100;
        static int[] stack = new int[max];
        static public bool push(int data) 
        {
            if (sp>=max)
            {
                Console.WriteLine("stack overflow");
                return false;
            }
            else
            {
                sp++;
                stack[sp] = data;
                return true;
            }
        }
        static public int pop() 
        {
            if (sp<0)
            {
                Console.WriteLine("stack underflow");
                return 0;
            }
            else
            {
                int data = stack[sp];
                sp--;
                return data;
            }
        }
        static public void printstack() 
        {
            if (sp < 0) 
            
            {
                Console.WriteLine("stack underflow");
                return;
            }
            else
            {
                Console.WriteLine("yığın içeriği");
                for (int i = sp; i <=0; i--)
                {
                    Console.WriteLine(stack[i]);
                }
            }
        }
        static public void peek() 
        {
            if (sp<0)
            {
                Console.WriteLine("stack underflow");
                return;
            }
            else
            {
                Console.WriteLine("en üstteki eleman"+stack[sp]);
            }
        }
        static void Main(string[] args)
        {
            push(10);
            push(20);
            push(30);
            push(40);
            printstack();
            Console.WriteLine("silindi"+pop());
            Console.WriteLine("silindi"+pop());
            printstack();
            peek();
            Console.ReadLine();
        }
    }
}
