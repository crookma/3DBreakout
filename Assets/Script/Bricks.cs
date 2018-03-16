/* Magnus Crooke
 * 3-15-18
 * This code is responsible for the bricks
 */ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour {

	public GameObject brickParticle; //The brick particles

	void OnCollisionEnter (Collision other) //Manages the bricks
	{
		Instantiate (brickParticle, transform.position, Quaternion.identity);
		GM.instance.DestroyBrick (); //Destroys the brick
		Destroy (gameObject); //Destroys the brick
	}
}
