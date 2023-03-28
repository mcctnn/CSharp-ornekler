using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
            doublyLinkedList = doublyLinkedList.orderlyInsert(doublyLinkedList,77);
            doublyLinkedList = doublyLinkedList.orderlyInsert(doublyLinkedList, 12);
            doublyLinkedList = doublyLinkedList.orderlyInsert(doublyLinkedList, 20);
            doublyLinkedList = doublyLinkedList.orderlyInsert(doublyLinkedList, 36);
            doublyLinkedList = doublyLinkedList.orderlyInsert(doublyLinkedList, 45);
            doublyLinkedList.print(doublyLinkedList);
            for (int i = 1; i < 96; i++)
            {
                DoublyLinkedList doublyLinkedList1 = new DoublyLinkedList();
                doublyLinkedList1 = doublyLinkedList1.orderlyInsert(doublyLinkedList1,i);
                doublyLinkedList1.print(doublyLinkedList1);
            }
            Console.ReadLine();
        }
        
    
    
    }
        
}
