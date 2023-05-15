using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldV2
{
    internal class Class1
    {
        public int StrStr(string haystack, string needle)
        {   int j = -1;
            if (haystack.Equals(needle))
            {
                return 0;
                
            }
            for (int i = 0; i < haystack.Length - needle.Length; i++)
            {
                if (haystack[i] == needle[0])
                {
                    j = i;
                    for (int j2 = 0;j2 < needle.Length; j2++)
                    {
                        if (haystack[i + j2] != needle[j2])
                        {
                            j = -1;
                        }
                    }
                    
                }
            }
            return j;
        }


        public  void Rotate(int[] nums, int k)
        {
            int[] ints = new int[nums.Length];
            
            for(int i  = nums.Length - k; i < nums.Length ;i++)
            {
                ints[i] = nums[i];
            }
            for(int i = 0;i < k;i++)
            {
                ints[i] = nums[i];
            }
            nums = ints;
        }
        public void SortColors(int[] nums)
        {
            int zero = 0;
            int two = nums.Length - 1;
            int i  = 0;
            for(;i < two;i++)
            {
                if (nums[i] == 0)
                {
                    nums[i] = nums[zero];
                    nums[zero] = 0;
                    zero++;
                    //i = i -1;
                }
                if (nums[i] == 2)
                {
                    nums[i] = nums[two];
                    nums[two] = 2;
                    two--;
                    i--;

                }
                i++;

            }
            for (int j = 0; j < nums.Length; j++)
            {
                Console.WriteLine(nums[j]);
            }
                
        }
       

    }
}
