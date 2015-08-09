﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegatewithargexp
{
    class FileManager
    {
        public static void DeleteFile(string filename)
        {
            Console.WriteLine("{0} is deleted", filename);
        }
    }

    class PrintManager
    {
        public static void PrintFile(string filename)
        {
            Console.WriteLine("{0} sent to print", filename);
        }
    }

    delegate void Run(string file);
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter filename");
            string filename = Console.ReadLine();

            Console.WriteLine("1. Delete file");
            Console.WriteLine("2. Print file");
            int ch = int.Parse(Console.ReadLine());

            Run r;

            if (ch == 1)
                r = new Run(FileManager.DeleteFile);
            else
                r = new Run(PrintManager.PrintFile);

            //r(filename);          
            r.Invoke(filename);
        }
    }
}
