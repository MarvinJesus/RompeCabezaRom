using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BtnsMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

   public  void goSceneNivel1() {
        SceneManager.LoadScene("nivel1");
    }
    public void goSceneNivel2()
    {
        SceneManager.LoadScene("nivel2");
    }
    public void goSceneMenu()
    {
        SceneManager.LoadScene("menuPrincipal");
    }
}
