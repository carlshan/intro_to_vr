using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsolePrint : MonoBehaviour {
	
	public Vector2 location;
	public Vector2 homeLocation;
	private bool isHome;

	// Use this for initialization
	void Start () {
		location = new Vector2(1.0f, 2.0f);
		homeLocation = new Vector2(5f, 5f);
		isHome = false;
		print ("Welcome to Go Home!");
		print ("A game where you need to find your way back.");
	}

	private void CheckForMovement(KeyCode kc, Vector2 movementVector) {
		if (Input.GetKeyDown (kc)) { 
			location = location + movementVector;
			Vector2 pathToHome = location - homeLocation;
			float distance = (location - homeLocation).magnitude;
			print ("Location: " + location);
			print ("Distance to home: " + distance);
			if (location == homeLocation) {
				print ("You're home!");
				isHome = true;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (!isHome) {
			CheckForMovement (KeyCode.LeftArrow, new Vector2 (-1.0f, 0));
			CheckForMovement (KeyCode.RightArrow, new Vector2 (1.0f, 0));
			CheckForMovement (KeyCode.UpArrow, new Vector2 (0, 1.0f));
			CheckForMovement (KeyCode.DownArrow, new Vector2 (0, -1.0f));
		} 
	} 
}
