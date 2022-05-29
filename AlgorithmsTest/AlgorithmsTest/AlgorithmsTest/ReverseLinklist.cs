using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmsTest
{
    public class ReverseLinklist
    {
        public static void Test()
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);

            IEnumerable<int> newList = list.Reverse();

            foreach (var i in newList)
            {
                Console.WriteLine(i);
            }
        }
    }
    
    public class LinkNode<T>
    {
        public T Data { get; set; }
        public LinkNode<T> Next { get; set; }
        public LinkNode(T data)
        {
            Data = data;
            Next = null;
        }
        public LinkNode()
        {
            Next = null;
        }
    }

    
    public class LinkList<T>
    {
        public LinkNode<T> Head;
        public LinkList()
        {
            Head = new LinkNode<T>();
        }
        public void AddLinkNode(T valueToAdd)
        {
            var newNode = new LinkNode<T>(valueToAdd);
            LinkNode<T> tmp = Head;
            while (tmp.Next != null)
            {
                tmp = tmp.Next;
            }
            tmp.Next = newNode;
        }
        public void PrintAllNodes()
        {
            LinkNode<T> tmp = Head;
            while (tmp != null)
            {
                Console.WriteLine(tmp.Data);
                tmp = tmp.Next;
            }
        }
        public LinkNode<T> Reverse(LinkNode<T> node1, LinkNode<T> node2)
        {
            bool isHead = false;
            if (node1 == Head)
                isHead = true;
            LinkNode<T> tmp = node2.Next;
            node2.Next = node1;     //使Node2节点指向Node1节点
            if (isHead)             //头节点反转后就是尾节点，它的Next为空
                node1.Next = null;
            if (tmp == null)
                return node2;
            else
                return Reverse(node2, tmp);
        }
    }

}