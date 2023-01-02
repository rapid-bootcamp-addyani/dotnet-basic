using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic01Soal05
    {
        public static void CetakData(int n)
        {
            string[] deret = new string[n];
            for (int i = 0; i < n; i++)
            {
                if (i <= 2) deret[i] = "1";
                else deret[i] = (Convert.ToInt32(deret[i - 1]) + Convert.ToInt32(deret[i - 2]) + Convert.ToInt32(deret[i - 3])).ToString();
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(deret[i] + "\t");
            }
        }
    }
}
