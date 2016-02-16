using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertionSort
{
    class Program
    {
        //This is program to calculate insertion list
        static void Main(string[] args)
        {
            int[] list = new int[] { 5, 3, 1, 2, 4, 0 };
            int temp;
            for (int i = 0; i < list.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {

                    if (list[j] > list[i])
                    {
                        temp = list[j];
                        list[j] = list[i];
                        list[i] = temp;
                    }
                }
            }
            foreach(int h in list)
            {
                Console.WriteLine(h);
            }
            Console.ReadLine();
        }
    }
}
