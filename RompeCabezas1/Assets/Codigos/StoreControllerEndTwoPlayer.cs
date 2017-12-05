using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Codigos;
public class StoreControllerEndTwoPlayer : MonoBehaviour {
    public TextMesh TextInfoPlayer1;
    public TextMesh TextInfoPlayer2;
    public TextMesh TextScore1Plyer1;
    public TextMesh TextScore2Plyer1;
    public TextMesh TextScore3Plyer1;
    public TextMesh TextScore1Plyer2;
    public TextMesh TextScore2Plyer2;
    public TextMesh TextScore3Plyer2;
    private ListaScorePlayerOne listaPlayerOne;
    private ListaScorePlayerTwo listaPlayerTwo;
    void Start () {
        listaPlayerOne = ListaScorePlayerOne.getInstan();
        listaPlayerTwo = ListaScorePlayerTwo.getInstan();

    }
  
	
	// Update is called once per frame
	void Update () {
        if (listaPlayerOne.getDataForIndex(0) != -1)
        {
            TextInfoPlayer1.text = "  Records Jugador Uno: ";
            TextScore1Plyer1.text = "Record Uno: " + listaPlayerOne.getDataForIndex(0);
        }
        if (listaPlayerOne.getDataForIndex(1) != -1)
        {
            TextScore2Plyer1.text = "Record  Dos: " + listaPlayerOne.getDataForIndex(1);
        }
        if (listaPlayerOne.getDataForIndex(2) != -1)
        {
            TextScore3Plyer1.text = "Record Tres: " + listaPlayerOne.getDataForIndex(2);
        }
        //----------------------------------------------------------------------------------
        if (listaPlayerTwo.getDataForIndex(0) != -1)
        {
            TextInfoPlayer2.text = "  Records Jugador Dos: ";
            TextScore1Plyer2.text = "Record Uno: " + listaPlayerTwo.getDataForIndex(0);
        }
        if (listaPlayerTwo.getDataForIndex(1) != -1)
        {
            TextScore2Plyer2.text = "Record  Dos: " + listaPlayerTwo.getDataForIndex(1);
        }
        if (listaPlayerTwo.getDataForIndex(2) != -1)
        {
            TextScore3Plyer2.text = "Record Tres: " + listaPlayerTwo.getDataForIndex(2);
        }
    }
}
