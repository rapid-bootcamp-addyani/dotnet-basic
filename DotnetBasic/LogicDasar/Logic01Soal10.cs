using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic01Soal10
    {
        public static void CetakData(int n)
        {
            string[] deret = new string[n];
            for (int i = 0; i < n; i++)
            {
                deret[i] = ((int)Math.Pow(i, 3)).ToString(); 
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(deret[i] + "\t");
            }
        }
    }
}
