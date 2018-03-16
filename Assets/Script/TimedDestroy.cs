/* Magnus Crooke
 * 3-15-18
 * This code is responsible for destroying objects
 */ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedDestroy : MonoBehaviour {

	public float destroyTime = 1f; //Destroys the game object

	// Use this for initialization
	void Start () {
		
		Destroy (gameObject, destroyTime);

	}
}
