using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    public class CSharp_Second
    {
        int x = 1;
        int y = 2;

        public void CallAddition1()
        {
            int sum = x + y;

            Console.WriteLine("Sum : " + sum);
        }

        public void CallAddition()
        {
            int i = x;
            int j = y;

            int sum = i + j;

            Console.WriteLine("Sum of Two Number: " + sum);
        }

        public void CalAddition1(int p1, int p2)
        {
            int sum = p1 + p2;
            Console.WriteLine("Addition of two Perams: " + sum);
        }

        public void CalAddition1(int p1, int p2, int p3)
        { 
            int sum = p1 + p2 + p3;
            Console.WriteLine("Addition of three Perams: " + sum);
        }

        public int CalAddition1(int p1, int p2, int p3, int p4)
        {
            int sum = p1 + p2 + p3 + p4;
            Console.WriteLine("Addition of four Perams: " + sum);
            return sum;
        }

        public void CallMultiply()
        {
            int i = 30;
            int j = 40;

            int mul = i * j;

            Console.WriteLine("Mul of Two Number: " + mul);
        }
    }
}
