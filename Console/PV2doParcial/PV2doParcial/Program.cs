using System;
using System.Collections;
using System.Collections.Generic;

namespace PV2doParcial
{
    public class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack(); ;
            String v;
            Console.WriteLine("Ingresa paréntesis: ");
            v = Console.ReadLine();
            foreach (char i in v)
            {
                if (i=='['||i=='{'||i=='(')
                {
                    stack.Push(i);
                }
                else if (stack.Count>0)
                {
                    if (i==')')
                    {
                        stack.Pop();
                    }
                    else if (i==']')
                    {
                        stack.Pop();
                    }
                    else if (i=='}')
                    {
                        stack.Pop();
                    }
                }
            }
            if (stack.Count >= 1)
            {
                Console.Write("Ecuación no  balanceada");
            }
            else
            {
                Console.Write("Ecuación balanceada");
            }
        }
    }
}