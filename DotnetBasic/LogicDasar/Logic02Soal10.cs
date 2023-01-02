using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic02Soal10
    {
        public static void CetakData(int n)
        {
            string[,] deret = new string[n, n];
            int prediksi = n / 2;
            int angkaSatu = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0 && j == 0) deret[i,j] = (n).ToString();
                    else if (j == 0 && i <= n / 2) deret[i,j] = (Convert.ToInt32(deret[i - 1,j]) - 2).ToString();
                    else if (j == 0 && i > n / 2) deret[i,j] = (Convert.ToInt32(deret[i - 1,j]) + 2).ToString();
                    else deret[i,j] = " ";
                }

                if (i <= n / 2)
                {
                    for (int k = 1; k < prediksi + 1; k++)
                    {
                        deret[i,k] = (Convert.ToInt32(deret[i, k - 1]) - 2).ToString();
                        deret[i,n - k] = deret[i,k - 1];
                    }
                    prediksi--;
                }
                else
                {
                    for (int k = 1; k < prediksi + 3; k++)
                    {
                        deret[i,k] = (Convert.ToInt32(deret[i, k - 1]) - 2).ToString();
                        deret[i,n - k] = deret[i,k - 1];
                    }
                    prediksi++;
                }

                if (i > 0 && i <= n / 2)
                {
                    deret[i,n / 2 - i] = "1";
                    deret[i,n / 2 + i] = "1";
                    angkaSatu++;
                }
                else if (i > 0 && i > n / 2)
                {
                    angkaSatu--;
                    deret[i,n / 2 - angkaSatu] = "1";
                    deret[i,n / 2 + angkaSatu] = "1";
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
