using System;

namespace Addtwonumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode res = l1;
            int p = 0;
            int m = 0;
            while ((l1 != null || l2 != null) || p != 0)
            {
                if (l1 == null && l2 != null)
                {
                    l1 = new ListNode(l2.val + p);
                    p = l1.val / 10;
                    l2 = l2.next;
                }
                else if (l2 == null && l1 != null)
                {
                    l1.val += p;
                    p = l1.val / 10;
                }
                else if ((l1 == null && l2 == null) && p == 1)
                {
                    l1 = new ListNode(1);
                    m = 1;
                    p = 0;
                }
                else
                {
                    if (l1.val + l2.val + p < 10)
                    {
                        l1.val += l2.val + p;
                        p = 0;
                        l2 = l2.next;
                    }
                    else if (l1.val + l2.val + p >= 10)
                    {
                        l1.val += l2.val + p - 10;
                        p = 1;
                        l2 = l2.next;
                    }
                }
                l1 = l1.next;
            }
            //if (m == 1)
            //{
            //    ListNode x = res.next;
            //    ListNode y =
            //    while (x != null)
            //    {
            //        x = x.next;
            //    }

            //}
            return res;
        }
    }
}