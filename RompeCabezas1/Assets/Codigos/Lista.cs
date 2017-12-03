﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Codigos
{
    class Lista
    {
        private Node head = null;
        private int log;
        private static Lista instance;
        private Lista() {
            this.log = 0;
        }
        public static  Lista getInstan() {
            if (instance != null)
            {
                return instance;
            }
            else {
                instance = new Lista();
                return instance;
            } 
        }
        private Lista(Node pNext)
        {
            this.log = 0;
        }
        public Node getHead() {
            return head;
        }
        public void setHead(Node pHead) {
            this.head = pHead;
        }
        public bool isEmpty()
        {
            return this.head == null;
        }
        public int getLong() {
            return this.log;
        }
        public void setLong(int pLong) {
            this.log = pLong;
        }
        public void addFirs(int pData) {
            Node newNode = new Node();
            newNode.setData(pData);
            if (this.isEmpty())
            {
                setHead(newNode);
            }
            else {
                newNode.setNext(getHead());
                setHead(newNode);
            }
            int dLong = getLong();
            dLong++;
            this.setLong(dLong);
            Console.WriteLine("dato"+ pData);
        }
        public int search(int pDate) {
            Node aux = this.getHead();
            int value = 0;
            while (aux != null) {
                if (pDate == aux.getData())
                {
                    value = aux.getData();
                    return value;
                }
                else {
                    aux = aux.getNext();
                }

            }
            return value;
        }
        public int getDataForIndex(int pos)
        {
            Node aux = this.getHead();
            int cont = 0;
            int dato = -1;
            if (pos < 0 || pos >= getLong())
            {
                Console.WriteLine("La posicion insertada no es correcta");
            }
            else
            {
                while (aux != null)
                {
                    if (pos == cont)
                    {
                        dato = aux.getData();
                    }
                    aux = aux.getNext();
                    cont++;
                }
            }
            return dato;
        }
    }
}
