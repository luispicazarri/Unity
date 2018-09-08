using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCHi : MonoBehaviour {

	private bool isPlayerInside = false; 
	public GameObject infoPanel;
	public GameObject SpeechPanel;
	public AudioSource Sound;
	public AudioSource Music;
	
	// Use this for initialization
	void Start () {
		infoPanel.SetActive(false);
		SpeechPanel.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.E) && isPlayerInside){
			SpeechPanel.SetActive(true);
			Sound.Play();
			Music.Pause();
			
		}
	}
	
	private void OnTriggerEnter(Collider other){
		
		if(other.CompareTag("Player")){
			
			infoPanel.SetActive(true);
			Debug.Log("hola");
			isPlayerInside = true;
		}
	}
	
	private void OnTriggerExit(Collider other){
		if(other.CompareTag("Player")){
			infoPanel.SetActive(false);
			isPlayerInside = false;
			if(SpeechPanel){
				SpeechPanel.SetActive(false);
				Music.Play();
			}
		}
		
		
	}
}
