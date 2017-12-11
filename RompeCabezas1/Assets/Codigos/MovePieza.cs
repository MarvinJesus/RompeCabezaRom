using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MovePieza : MonoBehaviour {
    public string piezaEstado = "idle";
    public Transform edgeParticles;
    public KeyCode placePiece;
    public string checkPlacement = "";
    public static int totalScore;
    public static int cont;
    public AudioClip soundPiezaClick;
    public AudioClip soundOnePoint;
    public AudioClip soundNonePoint;
    private AudioSource fuenteAudio;
	void Start () {
        fuenteAudio = GetComponent<AudioSource>();
        cont = 0;
        totalScore = 0;
    }
	void Update () {
        if (piezaEstado == "pickedup")
        {
            Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Vector2 objectPosition = Camera.main.ScreenToWorldPoint(mousePosition);
            transform.position = objectPosition;
        }
        if (Input.GetKeyDown(placePiece))
        {
             checkPlacement = "y";
        }
    }
    void OnTriggerStay2D(Collider2D otro)
    {
        if ((otro.gameObject.name == gameObject.name) && (checkPlacement == "y") && (otro.tag != gameObject.tag)) {
            otro.GetComponent<BoxCollider2D>().enabled = false;
            GetComponent<BoxCollider2D>().enabled = false;
            transform.position = otro.gameObject.transform.position;
            piezaEstado = "locked";
            Instantiate(edgeParticles,otro.gameObject.transform.position,edgeParticles.rotation);
            checkPlacement = "n";
            GetComponent<SpriteRenderer>().color = new Color(1, 7, 1, 3);
            totalScore += 10;
            cont++;
            fuenteAudio.clip = soundOnePoint;
            fuenteAudio.Play();
        }
        if ((otro.gameObject.name != gameObject.name) && (checkPlacement == "y") && (otro.tag != gameObject.tag))
        {
            GetComponent<SpriteRenderer> ().color = new Color(1,1,1,.5f);
            checkPlacement = "n";
            totalScore -= 2;
            fuenteAudio.clip = soundNonePoint;
            fuenteAudio.Play();
        }
    }
    private void OnMouseDown()
    {
        piezaEstado = "pickedup";
        checkPlacement = "n";
        fuenteAudio.clip = soundPiezaClick;
        fuenteAudio.Play();
    }
    private void OnMouseUp()
    {
        piezaEstado = "locked";
        checkPlacement = "y";
    }
}
