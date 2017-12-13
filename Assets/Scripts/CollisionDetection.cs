using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class CollisionDetection : MonoBehaviour {
	public GameObject level;
	public AudioSource audSrc;
	public AudioClip[] audioClip;
	//public GameObject score;
	public int scoreValue;
	void playSound(int clip){
		//audio.clip = audioClip [clip];
		//audio.Play();
		audSrc.PlayOneShot(audioClip[clip]);
	}



	void OnCollisionEnter(Collision collidingObject){
		
		if (collidingObject.gameObject.name == "Enemy") {
			playSound (3);
			//Instantiate (gameOverText,gameOverText.gameObject.transform.position,gameOverText.gameObject.transform.rotation);
			TextMesh l = GameObject.Find("Level").GetComponent<TextMesh>();
			l.text = "Game Over";
			l.color = Color.red;
			Destroy (collidingObject.gameObject);
			//Destroy (gameObject);
			TextMesh score = GameObject.Find("ScoreVal").GetComponent<TextMesh>();
			PlayerPrefs.SetString ("Points",score.text);
			SceneManager.LoadScene (2);
		}

		if (collidingObject.gameObject.name.Contains("Coin")==true) {
			playSound (0);
			TextMesh score = GameObject.Find("ScoreVal").GetComponent<TextMesh>();
			int val = 0;
			int.TryParse(score.text, out val);
			score.text = (val+scoreValue).ToString();
			Destroy (collidingObject.gameObject);
		}
		if (collidingObject.gameObject.name.Contains("pPlane")==true) {
			playSound (2);
			TextMesh l = GameObject.Find("Level").GetComponent<TextMesh>();
			l.text = "Level Completed";
			l.color = Color.green;
			Destroy (collidingObject.gameObject);
			//System.Threading.Thread.Sleep (2000);
			TextMesh score = GameObject.Find("ScoreVal").GetComponent<TextMesh>();
			PlayerPrefs.SetString ("Points",score.text);
			SceneManager.LoadScene (1);
		}
		if (collidingObject.gameObject.name.Contains("finaldest")==true) {
			playSound (2);
			TextMesh score = GameObject.Find("ScoreVal").GetComponent<TextMesh>();
			PlayerPrefs.SetString ("Points",score.text);
			SceneManager.LoadScene (3);
		}

	}
}
