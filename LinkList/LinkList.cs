using System;
using System.Collections.Generic;
using System.Text;

namespace LinkList
{
    public class LinkList
    {
        private Node Head { get; set; }
        private Node Tail { get; set; }

        public int Length {get;set;}
        public void Add(int value)
        {
            var node = new Node(value);

            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                Tail = node;
                
            }
            Length++;
        }

        public void DeleteByPosition(int position)
        {
            if (Length == 1 && position == 0)
            {
                Head = null;
                Tail = null;
                Length = Length - 1;
            }
            else if (Length == 2 && position == 1)
            {
                Head.Next = null;
                Length = Length - 1;
            }
            else if (Length == position + 1)
            {
                var node =FindPreviousNode(position);
                if (node != null)
                {
                    node.Next = null;
                    Tail = node;
                    Length = Length - 1;
                }
            }
            else
            {
               var node= FindPreviousNode(position);
                if (node != null)
                {
                    node.Next = node.Next.Next;
                    Length = Length - 1;
                }

            }

        }

        private Node FindPreviousNode(int position)
        {
            var current = Head;
            if (position == 0)
                return current;
            else if (position >= 1 && position <=Length)
            {
                for (int i = 0; i < position-1; i++)  
                    current = current.Next;
                return current;
            }
            return null;
            
        }
        public void Print()
        {
            var current = Head;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }

        
    }
}
