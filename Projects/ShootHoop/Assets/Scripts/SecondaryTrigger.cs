using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryTrigger : MonoBehaviour {
	Collider expectedCollider;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ExpectCollider(Collider collider) {
		expectedCollider = collider;
	}

	/// <summary>
	/// OnTriggerEnter is called when the Collider other enters the trigger.
	/// </summary>
	/// <param name="other">The other Collider involved in this collision.</param>
	void OnTriggerEnter(Collider otherCollider)
	{
		if (expectedCollider == otherCollider) {
			ScoreKeeper sk = FindObjectOfType<ScoreKeeper>();
			sk.IncrementScore(1);
		}
	}
}
