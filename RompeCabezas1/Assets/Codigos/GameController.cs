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
    private bool endGame = true;
    public TextMesh Text;
    void Start () {
        endGame = true;
        numePlayers = selectCantPlayer.cantPlayer;
        lista = Lista.getInstan();
        if (numePlayers == 1)
        {
            Timer.time = 2000.0f;
        }
        else
        {
            Timer.time = 0f;
        } 
    }
	
	// Update is called once per frame
	void Update () {
       
        switch (numePlayers)
        {
            case 1:
                Text.text = "Tu puedes eres el mejor";
                if (Timer.time == 0 || MoverPieza.cont >= cantFichas)
                {
                    valueScore = MoverPieza.totalScore;
                    if (Timer.time < 70)
                    {
                        //valueScore = valueScore + BonusTime;
                    }
                    if (Timer.time == 0)
                    {
                        if (endGame)
                        {
                            Text.text = "Lo siento perdiste";
                            Invoke("goSceneGameOver", 3);
                            endGame = false;
                        }
                    }
                    else
                    {
                        if (endGame) {
                            Text.text = "Felicidades lo lograste";
                            Invoke("goSceneEnd", 2);
                            endGame = false;
                        }
                    }
                }
                break;
            case 2:
                Text.text = "Jugador :" + contJugador;
                if (MoverPieza.cont >= cantFichas)
                {   
                    valueScore = MoverPieza.totalScore;
                    if (contJugador == 1) {
                        Text.text = "Felicidades lo lograste jugador uno";
                        Invoke("goSceneEndPlayer1", 2);
                    }
                    else if (contJugador == 2)
                    {
                        Text.text = "Felicidades lo lograste jugador dos";
                        Invoke("goSceneEndPlayer2", 2);
                    }
                }
                break;
            default:
                break;
        }    
    }
    public static  int  getDataFromListScoreForIndex(int pIndex) {
        return lista.getDataForIndex(pIndex);
    }
    private void goSceneEnd()
    {
        lista.addRecordsOrders(valueScore);
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
