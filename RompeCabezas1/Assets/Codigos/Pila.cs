using System;
using Assets.Codigos;
public class Pila
{
    private  Node top;
    private static Pila instance;
    private int log;
    private Pila()
    {
	    this.setLong(0);

    }
    public static Pila getInstan()
    {
        if (instance != null)
        {
            return instance;
        }
        else
        {
            instance = new Pila();
            return instance;
        }
    }
    public int getLong()  { //Analizadora
	    return log;
    }
    public  Node getTope() {//Analizadora
	    return  this.top;
    }
    public void setLong(int plongitud)//Modificadora
    {
        this.log = plongitud;
    }
    public  void setTope(Node pnodo)//Modificadora
    { 
        this.top = pnodo;
    }
    public bool push(int pElem)
    {
        Node newNode = new Node(pElem);
        if (newNode == null)
        {
            return false;
        }
        else if (this.isEmpty())
        {
           this.setTope(newNode);
        }
        else
        {
            newNode.setNext(this.getTope());
            this.setTope(newNode);
        }
        this.log++;
        return true;
    }
    public bool pop()
    {
        Node aux;
        if (!(this.isEmpty()))
        {
            aux = this.getTope();
            this.setTope(this.getTope().getNext());
            this.setLong(log--);
            return true;
        }
        else
        {
            return false;
        }
    }

    public string  seePila()
    {
        string valoresPila = "";
        int contador = 1;
        int cont = 0;
        Node aux;
        aux = this.getTope();     // apunta al inicio de la lista

        while (this.log > cont)
        {
            valoresPila = valoresPila+"\nScore : " +aux.getData()+"\n" ;
            aux = aux.getNext();
            contador++;
            cont++;
        }
        return valoresPila;
    }
    public bool isEmpty()
    {
        return this.top == null;
    }
}
