using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour {
	Text text; 
	ScoreKeeper sk;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		sk = FindObjectOfType<ScoreKeeper> ();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Score: " + sk.score;

	}
}
