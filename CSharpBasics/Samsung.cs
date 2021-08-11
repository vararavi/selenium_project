using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    public class Samsung
    {
        public void CreateMobile()
        {
            Console.WriteLine("Initiated Default Mobile Build Request");
        }

        public void CreateMobile(String screenType)
        {
            Console.WriteLine("Initiated Mobile Build Request with Screen Type is "+ screenType);
        }

        public void CreateMobile(String screenType, String os)
        {
            Console.WriteLine("Initiated Mobile Build Request with Screen Type is " + screenType);
            Console.WriteLine("And OS is " + os);
        }

        public void OSystems()
        {
            Console.WriteLine("Anroid OS");
        }

        public void SamsungThemes()
        {
            Console.WriteLine("Samsung Themes");
        }

    }
}
