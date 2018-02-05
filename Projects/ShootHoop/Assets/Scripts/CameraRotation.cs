using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour {
	private GameObject floor;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		float rotationSpeed = 10.0f;
		float mouseX = Input.GetAxis ("Mouse X") * rotationSpeed;
		float mouseY = Input.GetAxis ("Mouse Y") * rotationSpeed;
		Camera camera = GetComponentInChildren<Camera> ();
		camera.transform.localRotation = Quaternion.Euler (-mouseY, 0, 0) * camera.transform.localRotation;
		transform.localRotation = Quaternion.Euler (0, mouseX, 0) * transform.localRotation;
	}
}
