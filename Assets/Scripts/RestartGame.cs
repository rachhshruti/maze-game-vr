using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

/// <summary>
/// This class handles collision with enemy, coins, door and the key
/// </summary>
/// <author>Shruti Rachh</author>
public class RestartGame : MonoBehaviour {
	
	/// <summary>
	/// Handles collision with restart and quit buttons on game over or
	/// or game completed screens
	/// </summary>
	void OnCollisionEnter(Collision collidingObject){
		// Restarts the game
		if (collidingObject.gameObject.name == "Restart") {
			Debug.Log (collidingObject.gameObject.name);
			SceneManager.LoadScene (0);
		}
		
		// Quits the game
		if (collidingObject.gameObject.name == "Quit") {
			Debug.Log (collidingObject.gameObject.name);
			Application.Quit();
		}
	}
}
