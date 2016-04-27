using System;
using System.Collections.Generic;

namespace LeetCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RemoveElements(null, 3));         //null
            Console.WriteLine("-------------------------------------------");
            var listNode1 = Init(1, 2, 3, 3, 4, 5, 3);
            Console.WriteLine(listNode1);                       //1->2->3->3->4->5->3
            Console.WriteLine(RemoveElements(listNode1, 3));    //1->2->4->5
            Console.WriteLine("-------------------------------------------");
            var listNode2 = Init(1, 2, 5, 7, 3, 7, 11, 53, 14, 7, 1, 88, 3, 0, 1, 7, 5, 2);
            Console.WriteLine(listNode2);                       //1->2->5->7->3->7->11->53->14->7->1->88->3->0->1->7->5->2
            Console.WriteLine(RemoveElements(listNode2, 7));    //1->2->5->3->11->53->14->1->88->3->0->1->5->2
            Console.WriteLine("-------------------------------------------");
            var listNode3 = Init(1, 1, 1);
            Console.WriteLine(listNode3);                       //1->1->1
            Console.WriteLine(RemoveElements(listNode3, 1));    //null
            Console.ReadLine();
        }

        static ListNode Init(params int[] nums)
        {
            ListNode ret = new ListNode(nums[0]);
            ListNode current = ret;

            for (int i = 1; i < nums.Length; i++)
            {
                var thisNode = new ListNode(nums[i]);
                current.Next = thisNode;
                current = thisNode;
            }
            return ret;
        }

        static ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null)
                return null;

            var pre = head;
            var cur = head.Next;
            while (cur != null)
            {
                if (cur.Val == val)
                    pre.Next = cur.Next;
                else
                    pre = pre.Next;
                cur = pre.Next;
            }

            if (head.Val == val)
                head = head.Next;

            return head;
        }

    }

    public class ListNode
    {
        public int Val { get; set; }
        public ListNode Next { get; set; }

        public ListNode(int x)
        {
            Val = x;
        }

        public override string ToString()
        {
            return Next == null ? Val + "" : Val + "->" + Next;
        }
    }

}
