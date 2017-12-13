using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

/// <summary>
/// This class used to preserve score across levels
/// </summary>
/// <author>Prerna Preeti</author>
public class Score : MonoBehaviour {
	void Update(){
		DontDestroyOnLoad (transform.gameObject);
	}
}
