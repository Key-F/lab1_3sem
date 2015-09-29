using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Compn : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            int x1 = Convert.ToInt32(x);
            int y1 = Convert.ToInt32(y);
            if (x1 == y1) { return 0; }
            if (x1 > y1) { return 1; }
            if (x1 < y1) { return -1; }
            throw new Exception("Impossible!");
        }
    }
     
    class Program
    {
        private static void Display(List<string> list)
        {
            Console.WriteLine();
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
        }
        static void Main(string[] args)
        {
           Random rnd = new Random();
           List<string> listnum = new List<string>();
           Compn cp = new Compn();
            for (int i = 1; i<100; i++)
            {
               string x = rnd.Next(0, 101).ToString();
              // string y = x.ToString();
               //listnum.Add(rnd.Next(0, 101).ToString());
              // if (listnum.Contains(x))
               do
               { x = rnd.Next(0, 101).ToString(); }
               while (listnum.Contains(x));
                listnum.Add(x); 
            }
            Display(listnum);
            listnum.Sort(cp);
            Display(listnum);
            Console.ReadKey(true);
            //Sort(IComparer<T>)
        }
    }
}
