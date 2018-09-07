using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactive : MonoBehaviour {
	
	public Color color;
	
	private bool isPlayerInside = false; 
	
	public GameObject infoPanel; 
	
	public int multiplier;
	
	private void Start(){
		infoPanel.SetActive(false);
	}
	
	private void Update(){
		
		transform.Rotate(Vector3.up * Time.deltaTime * multiplier);
		
		if(Input.GetKeyDown(KeyCode.I) && isPlayerInside){
			gameObject.GetComponent<Renderer>().material.color = color;
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
		}
	}
	
}
