using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Assets.Codigos;
public class GameController : MonoBehaviour {
    private static int BonusTime = 100;
    private int valueScore;
    public int cantFichas = 9;
    private static Lista lista;
    void Start () {
        lista = Lista.getInstan();
        Timer.time = 10500.0f;
    }
	
	// Update is called once per frame
	void Update () {
        if (Timer.time == 0 || MoverPieza.cont >= cantFichas) {
            valueScore = MoverPieza.totalScore;
            if (Timer.time > 100) {
                //valueScore = valueScore + BonusTime;
            }
            Timer.time = 0;
            lista.addFirs(valueScore);
            SceneManager.LoadScene("sceneEnd");

        }
    }
    public static  int  getDataFromListScoreForIndex(int pIndex) {

            return lista.getDataForIndex(pIndex);
     

    }
}
