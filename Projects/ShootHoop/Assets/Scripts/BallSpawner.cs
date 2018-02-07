using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BallSpawner : MonoBehaviour {
	public GameObject ballPrefab;
	public float ballSpeed;
	Camera cam;

	void createBallOnPress(Vector3 veloc)
    {
		GameObject instance = Instantiate(ballPrefab);

		instance.transform.position = transform.position + transform.forward * 2;
		//instance.transform.rotation = ;
        Rigidbody rb = instance.GetComponent<Rigidbody>();
		veloc = cam.transform.rotation * Vector3.forward * ballSpeed;
        rb.velocity = veloc;
    }

	// Use this for initialization
    void Start()
    {
		cam = GetComponentInChildren<Camera> ();
		ballSpeed = 15.0f;	
    }
		
	
	// Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            createBallOnPress(Vector3.forward * ballSpeed);
        }

    }
}
