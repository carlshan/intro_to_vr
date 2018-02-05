using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageLevels : MonoBehaviour {
	public float timeTilNextLevel = 15.0f;

	// Use this for initialization
	void Start () {
	}

	public void LoadNextScene() {
		int currentSceneIndex = SceneManager.GetActiveScene ().buildIndex;
		int nextSceneIndex = (currentSceneIndex + 1) % 3;
		SceneManager.LoadScene (nextSceneIndex);
	}

	// Update is called once per frame
	void Update () {
		if (timeTilNextLevel > 0) {
			timeTilNextLevel -= Time.deltaTime; 
		}
		if (timeTilNextLevel < 0) {
			LoadNextScene ();
		}
	}
}
