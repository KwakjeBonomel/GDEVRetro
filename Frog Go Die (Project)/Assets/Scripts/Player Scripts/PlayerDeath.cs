﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDeath : MonoBehaviour {

	public static void DeathBy(Enemy enemy){
		if (enemy.tag == "Car"){
			SceneManager.LoadScene("GameOverCar");
		}
		if (enemy.tag == "Snake"){
			SceneManager.LoadScene("GameOverSnake");
		}
		if (enemy.tag == "Croc"){
			SceneManager.LoadScene("GameOverCroc");
		}
		if (enemy.tag == "CrocLog"){
			SceneManager.LoadScene("GameOverCroclog");
		}
	}
}
