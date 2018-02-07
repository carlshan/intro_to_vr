using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScoreDisplay : MonoBehaviour {
	Text text;
	ScoreAbsorber absorber;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text>();
		absorber = FindObjectOfType<ScoreAbsorber>();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Score: " + absorber.score;
	}
}
