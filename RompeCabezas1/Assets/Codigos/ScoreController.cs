using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreController : MonoBehaviour {

	void Start () {
	}

	void Update () {
        GetComponent<TextMesh>().text = "Score : " + (MoverPieza.totalScore).ToString();
        

    }
}
