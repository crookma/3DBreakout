/* Magnus Crooke
 * 3-15-18
 * This code is responsible for the paddle
 */ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	public float paddleSpeed = 1f; //Speed of the paddle

	private Vector3 playerPos = new Vector3 (0, -9.5f, 0); 


	
	// Update is called once per frame
	void Update () { //The horizontal movement of the paddle
		float xPos = transform.position.x + (Input.GetAxis ("Horizontal") * paddleSpeed);
		playerPos = new Vector3 (Mathf.Clamp (xPos, -8f, 8f), -9.5f, 0f);
		transform.position = playerPos;
	}
}
