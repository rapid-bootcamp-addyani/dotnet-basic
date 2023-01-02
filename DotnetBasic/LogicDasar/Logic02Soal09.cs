using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic02Soal09
    {
        public static void CetakData(int n)
        {
            string[,] deret = new string[n, n];
            int prediksi = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 && j == n / 2 || j == 0 && i == n / 2) deret[i,j] = "1";
                    else if (j == n / 2 && i <= n / 2) deret[i,j] = (Convert.ToInt32(deret[i - 1,j]) + 2).ToString();
                    else if (j == n / 2 && i > n / 2) deret[i,j] = (Convert.ToInt32(deret[i - 1,j]) - 2).ToString();
                    else deret[i,j] = " ";
                }

                if (i <= n / 2 && i > 0)
                {
                    for (int k = 1; k <= i; k++)
                    {
                        deret[i,n / 2 - k] = (Convert.ToInt32(deret[i,n / 2]) - 2 * k).ToString();
                        deret[i,n / 2 + k] = (Convert.ToInt32(deret[i, n / 2]) - 2 * k).ToString();
                    }
                    prediksi++;
                }
                else
                {
                    for (int k = 1; k <= prediksi; k++)
                    {
                        deret[i,n / 2 - k] = (Convert.ToInt32(deret[i, n / 2]) - 2 * k).ToString();
                        deret[i,n / 2 + k] = (Convert.ToInt32(deret[i, n / 2]) - 2 * k).ToString();
                    }   
                    prediksi--;
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
