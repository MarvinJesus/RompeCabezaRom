using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Codigos
{
    public class Cola
    {
        private Node front = null;
        private Node final = null;
        private int log;
        private static Cola instance;
        private Cola()
        {
            this.log = 0;
        }
        public static Cola getInstan()
        {
            if (instance != null)
            {
                return instance;
            }
            else
            {
                instance = new Cola();
                return instance;
            }
        }
        public Node getFront() {
            return this.front;
        }
        public void setFront(Node pfront) {
            this.front = pfront;
        }
        public Node getFinal() {
            return this.final;
        }
        public void setFinal(Node pfinal) {
            this.final = pfinal;
        }
        public int getLong() {
            return this.log;
        }
        public void insertElementInCola(int pdata) {
            Node newNode = new Node(pdata);
            newNode.setData(pdata);
            newNode.setNext(null);
            if (this.getFront() == null)
            {
                this.setFront(newNode);
                this.log++;
            }
            else {
                this.getFinal().setNext(newNode);
                this.log++;
            }
            this.setFinal(newNode);
        }
        public int  moveCola() {
            int value;
            Node aux;
            aux = this.getFront();
            value = aux.getData();
            this.setFront(this.getFront().getNext());
            this.log--;
            return value;
        }
        public void emptyCola(){
            this.setFront(null);
            this.setFinal(null);     
        }
        public void mostrarCola() {
            int cont = 1;
            Node aux;
            aux = this.getFront();
            while (aux != null)
            {
                Console.WriteLine(cont+"Valor: "+ aux.getData());
                aux = aux.getNext();
                cont++;
            }
        }
        public bool isEmpty() {
            return (this == null ? true : false);
        }
    }
}
