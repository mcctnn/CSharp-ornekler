using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[] { 4, 65, 74, 42, 11, 26, 36, 88 };
            dizi =DiziSirala(dizi);
            foreach (var item in dizi)
            {
                Console.Write(item+" ");
            }
            Console.ReadLine();
        }
        public static int[] DiziSirala(int[] dizi)
        {
            int temp;
            bool ofc;
            for (int i = 1; i <dizi.Length; i++)
            {
                ofc = true;
                for (int j = 0; j <dizi.Length-i; j++)
                {
                    if (dizi[j]<dizi[j+1])
                    {
                        ofc = false;
                        temp = dizi[j + 1];
                        dizi[j + 1] = dizi[j];
                        dizi[j] = temp;
                    }
                   
                }
                if (ofc)
                {
                    break;
                }
            }
            
            return dizi;
        }
    }

}
