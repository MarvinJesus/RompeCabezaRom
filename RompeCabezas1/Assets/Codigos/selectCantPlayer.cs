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
        SceneManager.LoadScene("menuPrincipal");
    }
}
