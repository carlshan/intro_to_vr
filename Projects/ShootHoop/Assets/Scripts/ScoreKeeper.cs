﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour {
	public int score;
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void IncrementScore(int amount) {
		score += amount;
		print ("Your score: " + score);
	}
}
