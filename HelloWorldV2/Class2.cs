using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldV2
{
    internal class Class2
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode ptr = new ListNode();
            ListNode l3 = ptr;
            int carry = 0;
            while (l1 != null &&l2 != null )
            {
                if (carry + l1.val + l2.val > 9) 
                {
                    
                    l3.val = (l2.val + l1.val + carry)%10;
                    carry = 1;
                }
                if (carry + l1.val + l2.val <= 9)
                {

                    l3.val = (l2.val + l1.val + carry)% 10;
                    carry = 0;

                }
                l2 = l2.next;
                l1 = l1.next;
                l3.next = new ListNode();
                l3 = l3.next;
                l3.val = carry;
            }

            if(l1 != null)
            {
                while (l1 != null) 
                {
                    l3.next = new ListNode();
                    l3.val = (l1.val + carry)%10;
                    l1 = l1.next;
                    carry = (carry + l1.val) / 10;
                }
            }
            if (l2 != null)
            {
                while (l2 != null)
                {
                    l3.next = new ListNode();
                    l3.val = (l2.val + carry) % 10;
                    l2 = l2.next;
                    carry = (carry + l2.val) / 10;
                }
            }
            if (carry == 1)
            {
                l3.next = new ListNode();
                l3.val = 1;
            }
            return ptr;
        }
    }
      public class ListNode
     {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
  }
}
