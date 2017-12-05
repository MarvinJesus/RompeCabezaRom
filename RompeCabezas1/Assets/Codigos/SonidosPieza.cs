using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidosPieza : MonoBehaviour {

   public AudioClip sounPiece;
    private AudioSource fuenteAudio;
	void Start () {
        fuenteAudio = GetComponent<AudioSource>();

    }
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        fuenteAudio.clip = sounPiece;
        fuenteAudio.Play();
    }
}
