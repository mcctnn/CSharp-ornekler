using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xx
{
    public class DoublyLinkedList
    {
        Node root;
        public DoublyLinkedList insert(DoublyLinkedList doublyLinkedList,int _veri)
        {
            Node yeniDugum = new Node(_veri);
            if (doublyLinkedList.root==null)
            {
                doublyLinkedList.root = yeniDugum;
            }
            else
            {
                Node iter = doublyLinkedList.root;
                while (doublyLinkedList.root!=null)
                {
                    iter = iter.next;
                }
                iter.next = yeniDugum;
                yeniDugum.prev = iter;
            }
            return doublyLinkedList;
        }
        public void print(DoublyLinkedList doublyLinkedList)
        {
            Node iter = doublyLinkedList.root;
            while (iter!=null)
            {
                Console.WriteLine(iter._veri+" ") ;
                iter = iter.next;
            }
        }
        public DoublyLinkedList orderlyInsert(DoublyLinkedList doublyLinkedList,int _veri)
        {
            Node yeniDugum = new Node(_veri);
            if (doublyLinkedList.root==null)
            {
                doublyLinkedList.root = yeniDugum;
            }
            else if (yeniDugum._veri<doublyLinkedList.root._veri)
            {
                yeniDugum.next = doublyLinkedList.root;
                yeniDugum.prev = null;
                doublyLinkedList.root.prev = yeniDugum;
                doublyLinkedList.root = yeniDugum;
            }
            else
            {
                Node iter = doublyLinkedList.root;
                while (iter.next != null && iter.next._veri< yeniDugum._veri)
                {
                    iter = iter.next;
                }
                Node tmp = iter.next;
                iter.next = yeniDugum;
                yeniDugum.prev = iter;
                yeniDugum.next = tmp;
                if (tmp!=null)
                {
                    tmp.prev =yeniDugum;
                }
            }
            return doublyLinkedList;
        }
        
    }
}
