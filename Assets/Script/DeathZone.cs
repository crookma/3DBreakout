/* Magnus Crooke
 * 3-15-18
 * This code is responsible for the boundary
 */ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour {

	void OnTriggerEnter (Collider col) //The boundary of the game
	{
		GM.instance.LoseLife ();
	}
}
