using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BtnsMenu : MonoBehaviour {
	void Start () {}
	void Update () {}
   public  void goSceneNivel1() {
        SceneManager.LoadScene("nivel1");
    }
    public void goSceneNivel2()
    {
        SceneManager.LoadScene("nivel2");
    }
    public void goSceneNivel3()
    {
        SceneManager.LoadScene("nivel3");
    }
    public void goSceneNivel4()
    {
        SceneManager.LoadScene("nivel4");
    }
    public void goSceneNivel5()
    {
        SceneManager.LoadScene("nivel5");
    }
    public void goSceneMenuOnePlayer()
    {
        SceneManager.LoadScene("menuPrincipalOnePlayer");
    }
    public void menuPrincipalOnePlayerScores()
    {
        SceneManager.LoadScene("menuPrincipalOnePlayerScores");
    }
    public void goSceneMenuTwoPlayer()
    {
        SceneManager.LoadScene("menuPrincipalTwoPlayer");
    }
    public void goVewWinner()
    {
        SceneManager.LoadScene("sceneGanador");
    }
    public void goSelectCantPlayers()
    {
        SceneManager.LoadScene("selectNumPlayers");
    }
    public void goSeeRecords()
    {
        SceneManager.LoadScene("seeRecordsPila");
    }
    public void goSeeRecordsLista()
    {
        SceneManager.LoadScene("seeRecordsLista");
    }
    public void goSeeRecordsCola()
    {
        SceneManager.LoadScene("seeRecordsCola");
    }
    public void aplicationExit()
    {
        Application.Quit();

    }
}

