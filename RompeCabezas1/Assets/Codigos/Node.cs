using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Codigos
{
    class Node
    {
        private int Data;
        private Node next;
        public Node() {}
        public Node(int pData) {
            this.setData(pData);
        }
        public Node getNext() {
            return next;
        }
        public void setNext(Node pnext) {
            this.next = pnext;
        }
        public int getData() {
            return this.Data;
        }
        public void setData(int pData) {
            this.Data = pData;
        }
    }
}
