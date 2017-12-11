using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class selectCantPlayer : MonoBehaviour {
    public static int cantPlayer;
	void Start () {}
	void Update () {}
    public void setCantPlayer(int pCantPlayer) {
        cantPlayer = pCantPlayer;
        if (cantPlayer == 1)
        {
            SceneManager.LoadScene("menuPrincipalOnePlayer");
        }
        else
        {
            SceneManager.LoadScene("menuPrincipalTwoPlayer");
        }
       
    }
}
