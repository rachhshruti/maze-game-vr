using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

/// <summary>
/// This class handles collision with enemy, coins, door and the key
/// </summary>
/// <author>Shruti Rachh</author>
public class CollisionDetection : MonoBehaviour {
	public GameObject level;
	public AudioSource audSrc;
	public AudioClip[] audioClip;
	public int scoreValue;
	
	/// <summary>
    /// Plays one of the audio clips from audioClip array given it's index
    /// </summary>
	///<param name=clip>audio clip index of the sound to be played</param>
	void playSound(int clip){
		audSrc.PlayOneShot(audioClip[clip]);
	}

	/// <summary>
    /// Handles collision with enemy, coin, door and key
    /// </summary>
	void OnCollisionEnter(Collision collidingObject){
		
		// Collision with enemy ends the game
		if (collidingObject.gameObject.name == "Enemy") {
			playSound (3);
			TextMesh l = GameObject.Find("Level").GetComponent<TextMesh>();
			l.text = "Game Over";
			l.color = Color.red;
			Destroy (collidingObject.gameObject);
			TextMesh score = GameObject.Find("ScoreVal").GetComponent<TextMesh>();
			PlayerPrefs.SetString ("Points",score.text);
			SceneManager.LoadScene (2);
		}
		
		// Collision with coin adds to the score
		if (collidingObject.gameObject.name.Contains("Coin")==true) {
			playSound (0);
			TextMesh score = GameObject.Find("ScoreVal").GetComponent<TextMesh>();
			int val = 0;
			int.TryParse(score.text, out val);
			score.text = (val+scoreValue).ToString();
			Destroy (collidingObject.gameObject);
		}
		
		// Collision with the key in case if it is not the last level, takes the player to next level
		if (collidingObject.gameObject.name.Contains("pPlane")==true) {
			playSound (2);
			TextMesh l = GameObject.Find("Level").GetComponent<TextMesh>();
			l.text = "Level Completed";
			l.color = Color.green;
			Destroy (collidingObject.gameObject);
			TextMesh score = GameObject.Find("ScoreVal").GetComponent<TextMesh>();
			PlayerPrefs.SetString ("Points",score.text);
			SceneManager.LoadScene (1);
		}
		
		// Collision with the key in case if it is the last level, takes the player to game completed screen
		if (collidingObject.gameObject.name.Contains("finaldest")==true) {
			playSound (2);
			TextMesh score = GameObject.Find("ScoreVal").GetComponent<TextMesh>();
			PlayerPrefs.SetString ("Points",score.text);
			SceneManager.LoadScene (3);
		}
	}
}
