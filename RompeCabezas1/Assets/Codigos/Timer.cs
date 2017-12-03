using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {
    static public float time = 1500.0f;
    void Start () {
		
	}
	void Update () {
        time = time - 1;
        if (time <= 0) {
            time = 0;
        }
        GetComponent<TextMesh>().text = "Time :" + time;
    }
}
