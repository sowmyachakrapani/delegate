using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateInvocationList
{
    class Database
    {
        public static void Connect()
        {
            Console.WriteLine("Db connection");
        }
        public static void Transaction()
        {
            Console.WriteLine("Do transaction");
        }
    }
    public delegate void Run();

    class Program
    {
        static void Main(string[] args)
        {
            Run r = new Run(Database.Connect);
            r += new Run(Database.Transaction);

            Delegate[] list = r.GetInvocationList();

           for (int i = 0; i < list.Length; i++)
                Console.WriteLine(list[i].Method);
        }
    }
}
