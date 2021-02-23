using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace lab2
{
    class Program
    {
        
        static int amount_of_unique_symbols(string line, Dictionary< char,string> coder )
        {
            int amount = 0;
            //string ss = line;
            bool flag = true;
            
            
            
            for (int i = 0; i < line.Length; i++)
            {
                
                int j = i+1;
                
                while ( j < line.Length && flag)
                {
                    if (line[i] == line[j]) flag = false;
                    ++j;
                }

                if (flag)
                {
                    coder.Add(line[i],Convert.ToString(amount, 2)); 
                    ++amount;
                }

                flag = true;

            }

            return amount;
        }
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите строку: ");
            string str = Console.ReadLine();
            str = str.ToLower();
            string sss = str;
            Dictionary<char, string> coder = new Dictionary<char,string>();


            Console.Write("Количество уникальных символов: ");
            Console.WriteLine(amount_of_unique_symbols(str,  coder));

            Console.WriteLine("Алфавит:");
            foreach(var iter in coder)
            {
                Console.WriteLine($"\'{iter.Key}\' - {iter.Value.PadLeft(4,'0')}");
            }
            
            Console.Write("Перевод: ");

            foreach(var iter in str)
            {
                Console.Write(coder[iter].PadLeft(4,'0'));
            }
        }
    }
}