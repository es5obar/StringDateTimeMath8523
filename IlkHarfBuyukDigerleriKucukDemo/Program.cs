﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IlkHarfBuyukDigerleriKucukDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad = "dOLMAbahçe SarAYı";
            string sonuc = FirstLetterToUpperOthersToLower(ad);
            Console.WriteLine(sonuc);

            string bogac = BogacMethodu(ad);
            Console.WriteLine(bogac);
            Console.ReadLine();
        }

        static string FirstLetterToUpperOthersToLower(string value)
        {
            char[] characters = new char[value.Length];
            //string charString;
            //string upperCharString;
            string result ="";
            for (int i = 0; i < characters.Length; i++)
            {
                characters[i] = value[i];
            }
            for (int i = 0; i < characters.Length; i++)
            {
                if (i==0)
                {
                    //charString = characters[i].ToString();
                    //upperCharString = charString.ToUpper();
                    //characters[i] = upperCharString[0];
                    characters[i] = characters[i].ToString().ToUpper()[0];

                }
                else
                {
                    characters[i] = characters[i].ToString().ToLower()[0];
                }
            }
            foreach (char c in characters)
            {
                result = result + c;
            }
            return result;
        }
        static string BogacMethodu(string value)
        {
            value = value.ToLower();
            string ilkHarf = value.Substring(0, 1);
            return ilkHarf.ToUpper() + value.Substring(1);
        }
    }
}
