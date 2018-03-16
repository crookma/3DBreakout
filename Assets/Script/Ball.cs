/* Magnus Crooke
 * 3-15-18
 * This code is responsible for the ball
 */ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public float ballInitialVelocity = 600f; //speed of the ball


	private Rigidbody rb; // Rigidbody for the game
	private bool ballInPlay; // Plays the ball

	// Use this for initialization
	void Awake () {

		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetButtonDown("Fire1") && ballInPlay == false) // Click to fire the ball
		{	
			transform.parent = null;
			ballInPlay = true;
			rb.isKinematic = false;
			rb.AddForce(new Vector3(ballInitialVelocity, ballInitialVelocity, 0f));
		}
	}
}
