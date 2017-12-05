using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Codigos;
public class ControllerWinner : MonoBehaviour {

    public TextMesh TextPrincipal;
    public TextMesh TextScore1;
    public TextMesh TextScore2;
    public TextMesh TextScore3;
    private ListaScorePlayerOne listaPlayerOne;
    private ListaScorePlayerTwo listaPlayerTwo;
    private int TotalScorePlayerOne = 0;
    private int TotalScorePlayerTwo= 0;
    void Start () {
        listaPlayerOne = ListaScorePlayerOne.getInstan();
        listaPlayerTwo = ListaScorePlayerTwo.getInstan();
        for (int i = 0; i < listaPlayerOne.getLong(); i++)
        {
            TotalScorePlayerOne = TotalScorePlayerOne + listaPlayerOne.getDataForIndex(i);
        }
        for (int i = 0; i < listaPlayerTwo.getLong(); i++)
        {
            TotalScorePlayerTwo = TotalScorePlayerTwo + listaPlayerTwo.getDataForIndex(i);
        }
        if (TotalScorePlayerOne > TotalScorePlayerTwo) {
            TextPrincipal.text = "El Ganador Jugador Uno";
            TextScore1.text = "" + TotalScorePlayerOne;
            TextScore2.text = "El Perdedor Jugador Dos";
            TextScore3.text = "" + TotalScorePlayerTwo;
        }
        if (TotalScorePlayerOne < TotalScorePlayerTwo)
        {
            TextPrincipal.text = "El Ganador Jugador Dos";
            TextScore1.text = "" + TotalScorePlayerTwo;
            TextScore2.text = "El Perdedor Jugador Uno";
            TextScore3.text = "" + TotalScorePlayerOne;
        }
        if (TotalScorePlayerOne == TotalScorePlayerTwo) {
            TextPrincipal.text = "No hay ganador esto es un empate";
        }
    }
}
