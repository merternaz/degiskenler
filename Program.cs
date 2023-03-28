using System;
using System.Collections.Generic;


namespace methods
{
    class Program
    {
         static void Main(string[] args)
        {
            string s="a";
            string number1="123";
            byte b=2;
            double d=5;
            float f=2.6f;
            uint ui=1;
            ulong ul=1;
            //s=string.Empty;
            Console.WriteLine("string:"+s);
            Console.WriteLine("byte:"+b);
            Console.WriteLine("double:"+d);
            Console.WriteLine("float:"+f);
            Console.WriteLine("uint:"+ui);
            Console.WriteLine("ulong:"+ul);
            Console.WriteLine("multiple b*d:"+b*d);
            Console.WriteLine("convert:"+int.Parse(number1)*3);
            Console.WriteLine("string:"+s+number1);
        }
    }
}