using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab8_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            string path = @"E:\учёба Ирины\S# обучение\lab8.txt";
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
            using (StreamWriter ch = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    int chislo = Convert.ToInt32(rand.Next(10));
                    ch.WriteLine(chislo);
                    Console.WriteLine(chislo);
                }

            }
            double Sum= 0;
            string[] strNum;
            using (StreamReader strArray = new StreamReader(path))
            {
                while (!strArray.EndOfStream)
                {
                    strNum = strArray.ReadLine().Split();
                    foreach (string a in strNum)
                    {
                        if (a != null)
                        {
                            Sum += double.Parse(a);

                        }
                    }
                }
            }
            Console.WriteLine("Сумма ={0} ", Sum.ToString());
            Console.ReadKey();
        }
    }
}
