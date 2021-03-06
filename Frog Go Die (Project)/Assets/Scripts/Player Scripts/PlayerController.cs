﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public static PlayerController playerInstance;
	
	public Rigidbody2D player;
	public AudioSource walk;

    private void Awake() {
        if (playerInstance == null) {
            DontDestroyOnLoad(gameObject);
            playerInstance = this;
        }
        else if (playerInstance != this) {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			this.transform.parent = null;
			player.MovePosition(player.position + Vector2.up); 		// Moves the player 1 "unit" forward.
			walk.Play();
		}		
		if (Input.GetKeyDown(KeyCode.DownArrow)) {
			this.transform.parent = null;
			player.MovePosition(player.position + Vector2.down); 	// Moves the player 1 "unit" backwards.
			walk.Play();
		}		
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			this.transform.parent = null;
			player.MovePosition(player.position + Vector2.left); 	// Moves the player 1 "unit" to the left.
			walk.Play();
		}		
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			this.transform.parent = null;
			player.MovePosition(player.position + Vector2.right); 	// Moves the player 1 "unit" to the right.
			walk.Play();
		}

		// --- RRESTRICT MOVEMENT ---
		if (transform.position.x <= -4f) {											// X-Axis
			transform.position = new Vector2(-3.9f, transform.position.y);
		} else if (transform.position.x >= 4.3f) {
			transform.position = new Vector2(4.2f, transform.position.y);
		}
			
		if (transform.position.y <= -3.94f) {										// Y-Axis
			transform.position = new Vector3(transform.position.x, -3.94f, -3f);
		} else if (transform.position.y >= 1.55f) {
			transform.position = new Vector3(transform.position.x, 1.5f, -3f);
		}
	}
}
