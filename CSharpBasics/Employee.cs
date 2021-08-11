using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    public class Employee
    {
         int emp_ID;
         string emp_Name = null;

        public Employee()
        {
            Console.WriteLine("Constrcutor Called. ");
        }

        public Employee(String Name)
        {
            Console.WriteLine("Constrcutor Called, Name =  " + Name);
        }

        public Employee(int Name)
        {
            Console.WriteLine("Constrcutor Called, Name =  " + Name);
        }

        public Employee(int Name, int id)
        {
            Console.WriteLine("Constrcutor Called, Name =  " + Name);
        }

        public void SetEmployeeID(int Id)
        {
            emp_ID = Id;
        }

        public void SetEmployeeName(string name)
        {
            emp_Name = name;
        }

        public void GetEmployeeDetails()
        {
            Console.WriteLine(" EMP ID: " + emp_ID);
            Console.WriteLine(" EMP NAME: " + emp_Name);
        }

        public void PrintTenNumbers()
        {
            for(int i=0; i<20; i++)
            {
                Console.WriteLine("Number : " + i);
            }

        }

        public void PrintEvenNumbers()
        {

            for (int i = 0; i < 20; i++)
            {
                int val = i % 2;
                if (val == 0)
                {
                    if(i < 10)
                    {
                        Console.WriteLine("Even Number : " + i);
                    }
                    
                }
                else
                {
                    Console.WriteLine("Odd Number : " + i);
                }
            }

        }

        public void Whileloop()
        {
            int ival = 10;
            while (ival < 10)
            {
                ival++;
                Console.WriteLine("Valie of I: " + ival);
            }

            do
            {
                Console.WriteLine("Do While Valie of I: " + ival);
                ival++;
            } while (ival < 25);
        }

    }
}
