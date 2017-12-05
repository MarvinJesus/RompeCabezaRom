using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestructorObjetos : MonoBehaviour {
	void Start () {}
	void Update () {}
    private void OnTriggerEnter2D(Collider2D objet)
    {
      Destroy(objet.gameObject);
      Invoke("goMenuInit", 7);
    }
    void goMenuInit() {
        SceneManager.LoadScene("selectNumPlayers");
    }
}
