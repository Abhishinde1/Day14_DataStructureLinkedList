using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    internal class UC2
    {
        Node head;
        public void Addfirst(int newdata)
        {
            Node newnode = new Node(newdata);
            newnode.next = head;
            head = newnode;

        }
        public void display()
        {
            Node temp = this.head;
            if (temp == null);
            while (temp != null)
            {
                Console.Write(temp.data + "->");
                temp = temp.next;
            }

        }
    }
}

