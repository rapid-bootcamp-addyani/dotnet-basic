using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic02Soal05
    {
        public static void CetakData(int n)
        {
            string[,] deret = new string[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == n / 2 && j <= 2) deret[i,j] = "1";
                    else if (i == n / 2) deret[i,j] = (Convert.ToInt32(deret[i,j - 1]) + Convert.ToInt32(deret[i,j - 2]) + Convert.ToInt32(deret[i,j - 3])).ToString();
                    else deret[i,j] = " ";
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j <= i && j <= n / 2 && i <= n / 2 || j >= i && j >= n / 2 && i >= n / 2 || j <= i && i >= n / 2 && j <= n - i - 1 || j >= i && i <= n / 2 && j >= n - i - 1) deret[i, j] = deret[n / 2, j];
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
