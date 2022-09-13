using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkList
{
   
        public class LinkedList
        {
            Node head;
            public void Add(int newData)
            {
                Node newNode = new Node(newData);

                if (this.head == null)
                {
                    this.head = newNode;
                }
                else
                {
                    Node temp = this.head; //temp variable accesible only in this method
                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = newNode;
                }
              

            }
            public void display()
            {
                Node temp = this.head;//accessible only in display method
                if (temp == null) ;
              
                while (temp != null)
                {
                    Console.Write(temp.data + "->");
                    temp = temp.next;
                }

            }
        }
    
}
