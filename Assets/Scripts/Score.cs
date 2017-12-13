using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Score : MonoBehaviour {
	void Update(){
		DontDestroyOnLoad (transform.gameObject);
	}
}
