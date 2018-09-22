using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsPause : MonoBehaviour {
	
	private bool paused = false;
	public GameObject pausePanel;
	public GameObject HUDPanel;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyUp(KeyCode.I))
		{
			paused = !paused;	
			pausePanel.SetActive(paused);
			HUDPanel.SetActive(!paused);
			
			if(paused)
			Time.timeScale = 0;
			else
			Time.timeScale = 1;
		}
	}
	
	public void yButton(){
		paused = !paused;	
		pausePanel.SetActive(paused);
		HUDPanel.SetActive(!paused);
		
		if(paused)
		Time.timeScale = 0;
		else
		Time.timeScale = 1;
	
	}
	
}
