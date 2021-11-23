using System;
using System.IO;


namespace Zadanie_File_System
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Nikryuchkov\Desktop\6.3.2.ЭДП";
            if(Directory.Exists(path))
                {
                    foreach (string i in Directory.GetDirectories(path) )
                {
                    Console.WriteLine(i);
                    foreach (string k in Directory.GetDirectories(i))
                    {
                        Console.WriteLine(k);
                    }
                    foreach (string l in Directory.GetFiles(i))
                    {
                        Console.WriteLine(l);
                    }
                }
                    foreach (string j in Directory.GetFiles(path))
                {
                    Console.WriteLine(j);
                }
            }

            Console.ReadKey();




        }
    }
}
