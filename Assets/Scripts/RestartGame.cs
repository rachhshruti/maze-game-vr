using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class RestartGame : MonoBehaviour {
	




	void OnCollisionEnter(Collision collidingObject){
		
		if (collidingObject.gameObject.name == "Restart") {
			Debug.Log (collidingObject.gameObject.name);
			SceneManager.LoadScene (0);
		}
		if (collidingObject.gameObject.name == "Quit") {
			Debug.Log (collidingObject.gameObject.name);
			Application.Quit();
		}


	}
}
