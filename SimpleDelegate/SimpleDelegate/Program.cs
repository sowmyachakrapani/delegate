using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleDelegate
{
    public delegate void HelloDelegate(string mesg);
    class Program
    {
        static void Main(string[] args)
        {
            HelloDelegate del = new HelloDelegate(Hello);
            del("this is the message");
        }

        public static void Hello(string message)
        {
            Console.WriteLine(message);
        }
    }



}
