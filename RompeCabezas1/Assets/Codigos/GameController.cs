using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Assets.Codigos;
public class GameController : MonoBehaviour {
    private static int BonusTime = 100;
    private int valueScore;
    public int cantFichas = 9;
    private int numePlayers;
    private static int contJugador = 1;
    private static Lista lista;
    private static Cola cola;
    private static Pila pila;
    private bool endGame = true;
    public TextMesh Text;
    private string messa;
    void Start()
    {
        messa = "";
        endGame = true;
        numePlayers = selectCantPlayer.cantPlayer;
        lista = Lista.getInstan();
        pila = Pila.getInstan();
        cola = Cola.getInstan();
        if (numePlayers == 1)
        {
            Timer.time = 2000.0f;
        }
        else
        {
            Timer.time = 0f;
        }
    }
	void Update () {
        if (endGame)
        {
            Text.text = "";
        }
        switch (numePlayers)
        {
            case 1:
                actionOnePlayer();
                break;
            case 2:
                messa = "Jugador :" + contJugador;
                actionTwoPlayers();
                break;
            default:
                break;
        }
        Text.text = messa;
    }
    private void actionOnePlayer()
    {
        if (Timer.time == 0 || MovePieza.cont >= cantFichas)
        {
            valueScore = MovePieza.totalScore;
            if (Timer.time < 70)
            {
                //valueScore = valueScore + BonusTime;
            }
            if (Timer.time == 0)
            {
                if (endGame)
                {
                    messa = "Lo siento perdiste";
                    Invoke("goSceneGameOver", 3);
                    endGame = false;
                }
            }
            else
            {
                if (endGame)
                {
                    messa = "Felicidades lo lograste";
                    Invoke("goSceneEnd", 2);
                    endGame = false;
                }
            }
        }
    }
    private void actionTwoPlayers()
    {
        if (MovePieza.cont >= cantFichas)
        {
            valueScore = MovePieza.totalScore;
            if (contJugador == 1)
            {
                messa = "Felicidades lo lograste jugador uno";
                Invoke("goSceneEndPlayer1", 2);
            }
            else if (contJugador == 2)
            {
                messa = "Felicidades lo lograste jugador dos";
                Invoke("goSceneEndPlayer2", 2);
            }
        }
    }
    public static  int  getDataFromListScoreForIndex(int pIndex) {
        return lista.getDataForIndex(pIndex);
    }
    private void goSceneEnd()
    {
        lista.addRecordsOrders(valueScore);
        pila.push(valueScore);
        cola.insertElementInCola(valueScore);
        SceneManager.LoadScene("sceneEnd");
        Timer.time = 0;
    }
    private void goSceneGameOver()
    {
        valueScore = 0;
        lista.addRecordsOrders(valueScore);
        SceneManager.LoadScene("gameOver");
    }
    private void goSceneEndPlayer1()
    {
        ListaScorePlayerOne lista = ListaScorePlayerOne.getInstan();
        lista.addRecordsOrders(valueScore);
        contJugador = 2;
        SceneManager.LoadScene("sceneEndTwoPlayer");
    }
    private void goSceneEndPlayer2()
    {
        ListaScorePlayerTwo lista = ListaScorePlayerTwo.getInstan();
        lista.addRecordsOrders(valueScore);
        contJugador = 1;
        SceneManager.LoadScene("sceneEndTwoPlayer");
    }
}
