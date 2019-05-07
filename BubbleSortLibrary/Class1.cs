using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSortLibrary
{
    public class BubbleS
    {
        public static int[] BubbleSort(int[] massive)
        {
            int t;
            for (int i = 0; i < massive.Length; i++)
            {
                for (int j = i + 1; j < massive.Length; j++)
                {
                    if (massive[i] > massive[j])
                    {
                        t = massive[i];
                        massive[i] = massive[j];
                        massive[j] = t;
                    }
                }
            }
            return massive;
        }
    }
}
