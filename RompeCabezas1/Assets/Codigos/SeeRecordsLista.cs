using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Codigos;
public class SeeRecordsLista : MonoBehaviour {
    private static Lista lista;
    public Text text;
    private string data;
    public  GameObject parentPanelConte;
    void Start () {
        lista = Lista.getInstan();
        seeRecords();
    }
    private int seeRecords()
    {
        Node aux = lista.getHead();
        int cont = 0;
        int dato = -1;
        if (aux == null)
        {
            //Console.WriteLine("La posicion insertada no es correcta");
        }
        else
        {
            while (lista.getLong() > cont && aux != null)
            {
                data = "SCORE :"+ aux.getData();
                text = Instantiate(text);
                text.text = data;
                text.transform.parent = parentPanelConte.transform;
                text.transform.localScale = new Vector3 (1,1,1);
                text.transform.position = new Vector3(1, 1,0);
                aux = aux.getNext();
                cont++;
            }
        }
        return dato;
    }
}
