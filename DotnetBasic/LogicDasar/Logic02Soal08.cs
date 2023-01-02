using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic02Soal08
    {
        public static void CetakData(int n)
        {
            string[,] deret = new string[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    deret[i,j] = "0";
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j <= 1 || i <= 1 || i >= n - 2 || j >= n - 2) deret[i,j] = "1";
                    else if (j >= i && j < n - i) deret[i,j] = (Convert.ToInt32(deret[i - 1, n / 2]) + Convert.ToInt32(deret[i - 2, n / 2])).ToString();
                    else if (j >= n - i - 1 && j <= i) deret[i,j] = (Convert.ToInt32(deret[n - i - 2, n / 2]) + Convert.ToInt32(deret[n - i - 3, n / 2])).ToString();
                    else if (j <= n / 2) deret[i,j] = (Convert.ToInt32(deret[i, j - 1]) + Convert.ToInt32(deret[i, j - 2])).ToString();
                    else if (j >= n / 2) deret[i,j] = (Convert.ToInt32(deret[n / 2, n - j - 2]) + Convert.ToInt32(deret[n / 2, n - j - 3])).ToString();
                    else deret[i,j] = "0";
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (Convert.ToInt32(deret[i,j]) == 0) deret[i,j] = (Convert.ToInt32(deret[n / 2, n - j - 2]) + Convert.ToInt32(deret[n / 2, n - j - 3])).ToString();
                    if (!(j <= i && i >= n / 2 && j >= n - i - 1 && j <= n / 2 || j >= i && i <= n / 2 && j <= n - i - 1 && j >= n / 2)) deret[i,j] = " ";
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
