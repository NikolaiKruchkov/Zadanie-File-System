using System;
using System.IO;

namespace Zadanie_File_System_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Nikryuchkov\Desktop\New folder (2)\New Text Document.txt";
            
            int[] massiv = new int[10];
            Random random = new Random();
            StreamWriter sr = new StreamWriter(path);
            foreach (int i in massiv)
            {
                massiv[i] = random.Next();
                sr.WriteLine(massiv[i]);
               
            }
            sr.Close();
            StreamReader st = new StreamReader(path);
            StreamReader sk = new StreamReader(path);
            Console.Write(((st.ReadToEnd())));
            int[] massiv_2 = new int[10];
            int sm=0;
            foreach (int k in massiv_2)
            {
                massiv_2[k] =Convert.ToInt32( sk.ReadLine());
                sm = sm+ massiv_2[k];
                Console.WriteLine(massiv_2[k]);
            }
            Console.WriteLine("Сумма чисел в последовательности равна {0}", sm);
            Console.ReadKey();



        }
    }
}
