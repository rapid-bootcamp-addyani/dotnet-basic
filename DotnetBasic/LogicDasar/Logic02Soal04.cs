using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic02Soal04
    {
        public Logic02Soal04() { }
        public static void CetakData(int n)
        {
            string[,] deret = new string[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j <= 1 && i == 0) deret[i,j] = "1";
                    else if (i == 0) deret[i,j] = (Convert.ToInt32(deret[i, j - 1]) + Convert.ToInt32(deret[i, j - 2])).ToString();
                    else if (j == 0 || j == n / 2 || j == n - 1 || i == n / 2 || i == n - 1) deret[i,j] = deret[0,j];
                    else deret[i,j] = " ";

                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(deret[i, j] + "\t");
                }
                Console.WriteLine("");
            }
        }
    }
}
