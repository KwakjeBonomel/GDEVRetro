﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine;


public class MenuScript : MonoBehaviour {

	public AudioMixer master;

	public static bool paused = false;
	public GameObject pauseMenuUI;

	void Update(){					
		if (Input.GetKeyDown(KeyCode.Escape)){		// If the player presses the escape key the pause menu will open or close
			if (paused) Resume();					// depending on the current state of the pause variable. 
			else Pause();
		}
	}
	
	public void Resume(){					// Resumes the game when pressed.
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
		paused = false;
	}

	void Pause(){							// Pauses the game when pressed.
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		paused = true;
	}

	// Loads a random (playable) scene for the player to start te game.
	public void PlayGame(){
		Score.score = 0;
		SceneManager.LoadScene(Random.Range(1, 4));
	}

	public void QuitGame(){
		Application.Quit();								// Exits the aplication.
		Debug.Log("Quit!");
	}

	// Loads the Main Menu Scene
	public void MainMenu(){ SceneManager.LoadScene("MainMenu"); }
	
	
	// Toggles fullscreen
	public void FullScreen(){ Screen.fullScreen = !Screen.fullScreen; }
	
	// Changes the master Audio mixer's value based on the sliders value.
	public void SetVolume(float volume){ master.SetFloat("Volume", volume); }
}
