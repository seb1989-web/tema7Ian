using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoatLatin
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Goat2("I speak Goat Latin");



            Console.ReadLine();
        }
        
       

        public string Goat2(string s)
        {
            string a = "a";
            string str = "ma";
            string vowels = "a e i o u A E I O U";
            string[] vowels2 = vowels.Split(' ');
            string[] txt = s.Split(' ');
            
            for (int i = 0; i < txt.Length; i++)
            { 
                var l = txt[i][0];
                var firstLetter = l.ToString();
                if ( vowels2.Contains(firstLetter))
                {
                    txt[i] = txt[i] + str;
                }
                else
                {
                    txt[i] = txt[i].Remove(0, 1) + txt[i].Substring(0, 1) + str;
                }
                if (i >= 0)
                {
                    txt[i] = txt[i] + a;
                    Console.Write(txt[i] + " ");
                    a = a + 'a';
                }
            }
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in txt)
            {
                stringBuilder.Append(item + ' ');
            }
            return stringBuilder.ToString();
        }

    }
}
