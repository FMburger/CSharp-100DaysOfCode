using System;

namespace DeleteNodeinLinkedList
{
    class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    class Program
    {
        public void DeleteNode(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }
        static void Main(string[] args)
        {
            int[] i = { 1, 2, 5, 9 };
            ListNode n = new ListNode(5);
            Program s = new Program() ;
        }
    }
}
