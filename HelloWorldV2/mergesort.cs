using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldV2
{
    internal class mergesort
    {
        private void merge(int[] array, int l, int m, int r)
        {
            int i = l;
            int j = m + 1;
            int k = l;
            int[] b = new int[array.Length];
            while( i<= m && j<= r )
            {
                if(array[i] < array[j] )
                {
                    b[k] = array[l];
                    i++;
                    k++;
                }
                else
                {
                    b[k] = array[j];
                    j++; k++;
                }
                if(i > m)
                {
                    b[k] = array[j];
                    j++; k++;
                }
            }
        }
    }
}
