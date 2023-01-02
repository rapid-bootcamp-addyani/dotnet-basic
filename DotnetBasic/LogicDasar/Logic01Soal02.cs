using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic01Soal02
    {
        public static void CetakData(int n)
        {
            string[] deret = new string[n];
            for (int i = 0; i < n; i++)
            {
                if (i == 0) deret[i] = "1";
                else if (i == 1) deret[i] = "3";
                else if (i % 2 == 1) deret[i] = (Convert.ToInt32(deret[i - 2]) + 3).ToString();
                else deret[i] = (Convert.ToInt32(deret[i - 2]) + 1).ToString();
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(deret[i] + "\t");
            }
        }
    }
}
