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
    public void goSceneMenu()
    {
        SceneManager.LoadScene("menuPrincipal");
    }
    public void goVewWinner()
    {
        SceneManager.LoadScene("sceneGanador");
    }
    public void goSelectCantPlayers()
    {
        SceneManager.LoadScene("selectNumPlayers");
    }
    public void aplicationExit()
    {
        Application.Quit();

    }
}
