using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkList
{
    internal class UC7
    {
        Node head;
        public void AddEnd(int newData)
        {
            Node newNode = new Node(newData);

            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }

        public void Search(int value)
        {
            Node temp = this.head;
            if (temp != null)
            {
                while (temp != null)
                {
                    if (temp.data == value)
                    {
                        Console.WriteLine("{0} is present in the list", value);
                    }
                    temp = temp.next;

                }

            }
        }

    }
}
