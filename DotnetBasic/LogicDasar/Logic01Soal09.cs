using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic01Soal09
    {
        public static void CetakData(int n)
        {
            string[] deret = new string[n];
            for (int i = 0; i < n; i++)
            {
                deret[i] = ((int)Math.Pow(3, i)).ToString();
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(deret[i] + "\t");
            }
        }
    }
}
