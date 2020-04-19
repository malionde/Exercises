using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDecimalValue
{
    class Program
    {

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x){val = x;}
        }

        static void Main(string[] args)
        {
            ListNode listNode = new ListNode(1);
            ListNode listNode1 = new ListNode(0);
            ListNode listNode2 = new ListNode(1);

            listNode.next = listNode1;
            listNode1.next = listNode2;

            Console.WriteLine(GetDecimalValue(listNode));
            Console.ReadLine();
        }

        public static int GetDecimalValue(ListNode head)
        {
            int result = 0;
            while (head != null)
            {
                result = result * 2 + (head.val);
                head = head.next;
            }
            return result;
        }
    }
}
