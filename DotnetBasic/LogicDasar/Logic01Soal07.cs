using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDasar
{
    internal class Logic01Soal07
    {
        public static void CetakData(int n)
        {
            string[] deret = new string[n];

            //        String[] huruf = {"A","B","C", "D", "E","F","G","H", "I", "J",
            //                "K","L","M","N", "O","P", "Q","R", "S","T",
            //                "U","V","W","X", "Y","Z"};
            //
            //        int perulangan = 0;
            //        for(int i = 0; i< deret.length; i++){
            //            deret[i] = huruf[i-perulangan];
            //            if((i+1) % 26 == 0) perulangan = perulangan + 26;
            //        }

            char huruf = 'A';
            for (int i = 0; i < deret.Length; i++)
            {
                deret[i] = (huruf).ToString();
                huruf++;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(deret[i] + "\t");
            }
        }
    }
}
