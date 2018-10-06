using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections.Generic;

public class InventoryMenu : MonoBehaviour {
	
	private bool paused = false;
	public GameObject InventoryPanel;
	
	void Start(){
	}
	
	public void OnPressed(){
		paused = !paused;	
		InventoryPanel.SetActive(paused);
	}
}