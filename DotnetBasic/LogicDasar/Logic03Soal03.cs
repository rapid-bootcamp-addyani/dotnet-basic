using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic03Soal03
    {
        public static void CetakData(int n)
        {
            string[,] deret = new string[2, n];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(i == 0)
                    {
                        if(j == 0) deret[i, j] = "0";
                        else deret[i, j] = (Convert.ToInt32(deret[i, j-1]) + 2).ToString();
                    }
                    else
                    {
                        if (j == 0) deret[i, j] = "0";
                        else if ((j % 3) == 0 && j >= 2) deret[i, j] = Math.Pow(j, 3).ToString();
                        else deret[i, j] = "999";
                    }
                }
            }

            for (int i = 0; i < 2; i++)
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
