using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic01Soal03
    {
        public static void CetakData(int n)
        {
            string[] deret = new string[n];
            for (int i = 0; i < n; i++)
            {
                if (i == 0) deret[i] = "0";
                else deret[i] = (Convert.ToInt32(deret[i - 1]) + 2).ToString();
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(deret[i] + "\t");
            }
        }
    }
}
