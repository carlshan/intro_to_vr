using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeRemaining : MonoBehaviour {
	ManageLevels manage;
	Text text;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
		manage = FindObjectOfType<ManageLevels> ();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = "Time Remaining: " + Mathf.Floor(manage.timeTilNextLevel);
	}
}
