using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xx
{
    public class Node
    {
        public int _veri;
        public Node next;
        public Node prev;
        public Node(int veri)
        {
            this._veri = veri;
            this.next = null;
            this.prev = null;
        }
    }
}
