using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DelegateEnvocationlist
{
    public class Class1
    {
        public static void Connect()
        {
            Console.WriteLine("DB CONNECTION");
        }
        public static void Transaction()
        {
            Console.WriteLine("Do transaction");
        }

        public delegate void Run();

        class Program
        {
            static void Main(String[] args)
            {
                Class1 obj = new Class1();
                Run r = new Run(Class1.Connect);
                r += new Run(Class1.Transaction);

                Delegate[] list = r.GetInvocationList();
                for(int i=0;i<list.Length;i++)
                Console.WriteLine(list[i].Method);
          }

          }


    }
}