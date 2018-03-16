/* Magnus Crooke
 * 3-15-18
 * This code is responsible for managing the game
 */ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GM : MonoBehaviour {

	public int lives = 3; // Number of lives
	public int bricks = 20; // Number of bricks
	public float resetDelay = 1f; // Reset time
	public Text livesText; // Lives text
	public GameObject gameOver; // Game over text
	public GameObject youWon; // Winning text
	public GameObject bricksPrefab; // The bricks
	public GameObject paddle; // The paddle
	public GameObject deathParticls; // The death particles
	public static GM instance = null; // The game manager

	private GameObject clonePaddle;

	// Use this for initialization
	void Start () { // Starts Game and destroys the game object
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy (gameObject);

		Setup ();
	}

	public void Setup() // Resets the game
	{
		clonePaddle = Instantiate (paddle, transform.position, Quaternion.identity) as GameObject; 
		Instantiate (bricksPrefab, transform.position, Quaternion.identity);
	}

	void CheckGameOver() // Checks of the player won or lost
	{
		if (bricks < 1) {
			//youWon.SetActive (true);
			//Time.timeScale = .25f;
			//Invoke ("Reset", resetDelay);
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
		}

		if (lives < 1) {
			//gameOver.SetActive (true);
			//Time.timeScale = .25f;
			//Invoke ("Reset", resetDelay);
			SceneManager.LoadScene("GameOver");
		}
	}

	void Reset() // Resets the entire game
	{
		Time.timeScale = 1f;
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}
	
	public void LoseLife() // If the player losses the life then the life counter reduces and the game will end if all three of them are lost
	{
		lives--;
		livesText.text = "Lives: " + lives;
		Instantiate (deathParticls, clonePaddle.transform.position, Quaternion.identity);
		Destroy (clonePaddle);
		Invoke ("SetupPaddle", resetDelay);
		CheckGameOver ();
	}

	void SetupPaddle() // Moves the paddle
	{
		clonePaddle = Instantiate (paddle, transform.position, Quaternion.identity) as GameObject;
	}

	public void DestroyBrick() // Destroys the bricks when hit
	{
		bricks--;
		CheckGameOver ();
	}
}
