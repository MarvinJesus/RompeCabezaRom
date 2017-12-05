using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Codigos;
public class StoreControllerEnd : MonoBehaviour{
    public TextMesh TextScore1;
    public TextMesh TextScore2;
    public TextMesh TextScore3;
    void Start () {

    }
	void Update () {
        if (GameController.getDataFromListScoreForIndex(0) != -1)
        {
            TextScore1.text = "Record Uno: " + GameController.getDataFromListScoreForIndex(0);
        }
        if (GameController.getDataFromListScoreForIndex(1) != -1)
        {
            TextScore2.text = "Record  Dos: " + GameController.getDataFromListScoreForIndex(1);
        }
        if ( GameController.getDataFromListScoreForIndex(2) != -1)
        {
            TextScore3.text = "Record Tres: " + GameController.getDataFromListScoreForIndex(2);
        }
    }
}
