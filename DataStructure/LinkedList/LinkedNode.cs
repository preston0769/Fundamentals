using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure.LinkedList
{
    class LinkedNode
    {
        LinkedNode next;
        Object val;
        public LinkedNode(Object o) { this.val = o; }
    }

    class DoubleLinkedNode
    {
        DoubleLinkedNode pre;
        DoubleLinkedNode next;
        Object val;
        public DoubleLinkedNode(Object o) { this.val = 0; }
    }
}
