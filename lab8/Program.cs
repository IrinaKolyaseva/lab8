using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string papka = @"E:\учёба Ирины\S# обучение";
            if (Directory.Exists(papka))
            {
                Console.WriteLine("подкаталоги:");
                string[] papk = Directory.GetFiles(papka);
                foreach (string s in papk)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();
                string[] files = Directory.GetFiles(papka);
                foreach (string s in files)
                {
                    Console.WriteLine();
                }
            }
            Console.ReadKey();
        }
       
    }
}
