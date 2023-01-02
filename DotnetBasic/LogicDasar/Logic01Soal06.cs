using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic01Soal06
    {
        public static void CetakData(int n)
        {
            string[] deret = new string[n];
            int awal = 1;
            int akhir = 10;
            int bil, batas = 0;
            for (int i = awal; i <= akhir; i++)
            {
                bil = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        bil = bil + 1;
                    }
                }
                if (bil == 2)
                {
                    deret[batas] = (i).ToString();
                    if (batas == n - 1) break;
                    else
                    {
                        batas++;
                    }
                }
                akhir++;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(deret[i] + "\t");
            }
        }
    }
}
