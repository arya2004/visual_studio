using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Net;
using System.IO;
using System.ComponentModel.DataAnnotations;
using System;

namespace HelloWorldV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // // MaxSlidingWindow();
           //Class2 class2 = new Class2();
           //// class2.AddTwoNumbers();
           // ListNode n = new ListNode();
           // ListNode n1 = new ListNode();
           // ListNode n2 = new ListNode();
           // n1.val = 6;
           // n2.val = 5;
           // n1.next = new ListNode();
           // n2.next = new ListNode();
           // n1.next.val = 6;
           // n2.next.val = 7;
           // n1.next.next = new ListNode();
           // n2.next.next = new ListNode();
           // n1.next.next.val = 8;
           // //n2.next.next.val = 9;
           // ListNode n4 = new ListNode();
           // ListNode n5 = new ListNode();

           // n = class2.AddTwoNumbers(n1,n2);
           // while(n != null)
           // {
           //     Console.WriteLine(n.val);
           //     n = n.next;
           // }

            mergesort mergesort = new mergesort();
            
        }
        public static int[] MaxSlidingWindow2(int[] nums, int k)
        {
            int max = int.MinValue;
            int sMax = int.MinValue + 1;
            int maxp = -1;
            int sMaxp = -2;
            Queue<int> queue = new Queue<int>(k);
            int[] soln = new int[nums.Length - k + 1];
            if(k == 1)
            {
                return nums;
            }
            
            for (int i = 0; i < nums.Length; i++)
            {   

                if (queue.Count < k)
                {
                    
                    queue.Enqueue(nums[i]);
                    if (nums[i] >= max)
                    {
                        max = nums[i];
                        maxp = i;
                    }
                    if (nums[i] >=sMax && max >= nums[i] && maxp != sMaxp )
                    {
                        sMax = nums[i];
                        sMaxp = i;
                    }
                }

                if (queue.Count == k)
                {
                    soln[i-k+1] = max;
                    if(max.Equals(queue.Dequeue()))
                    {
                        Console.WriteLine(sMax);
                        max = sMax;
                        maxp = sMaxp;
                        //Console.WriteLine(max);
                        sMaxp = -2;
                        sMax = int.MinValue + 1;
                    }
                    
                }

            }
            return soln;
        }

        public static int[] MaxSlidingWindow(int[] nums, int k)
        {
 

            Queue<int> queue = new Queue<int>(k);
            int[] soln = new int[nums.Length - k + 1];
            if (k == 1)
            {
                return nums;
            }

            for (int i = 0; i < nums.Length; i++)
            {

                if (queue.Count < k)
                {

                    queue.Enqueue(nums[i]);

                }

                if (queue.Count == k)
                {
                    soln[i - k + 1] = queue.ToList().Max(); ;
                    
                    queue.Dequeue();
   

                }

            }
            return soln;
        }


    }
        class Car
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public bool IsNew()
        {
            return (Year > 2023);
        }
        public Car(string name, string model, int year, string color)
        {
            this.Name = name;
            Model = model;
            Year = year;
            Color = color;
        }
        public void showpiece()
        {
            Console.WriteLine(this.Name + " " + this.Model + " " + this.Year);
        }
    }

        
}