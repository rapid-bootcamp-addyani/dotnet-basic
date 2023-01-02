using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic01Soal08
    {
        public static void CetakData(int n)
        {
            string[] deret = new string[n];
            char huruf = 'A';
            int angka = 2;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    deret[i] = (huruf).ToString();
                    huruf++;
                    huruf++;
                }
                else
                {
                    deret[i] = (angka).ToString();
                    angka += 2;
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(deret[i] + "\t");
            }
        }
    }
}
