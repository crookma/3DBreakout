/* Magnus Crooke
 * 3-15-18
 * This code is responsible for managing the levels
 */ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void StartGame() { //Starts the game
		SceneManager.LoadScene ("3DBreakout"); //Starts the game
	}

	public void QuitGame() { //Quits the game
		Application.Quit ();
	}
}
