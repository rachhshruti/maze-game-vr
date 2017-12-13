using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class fetches the preserved score from previous level
/// </summary>
/// <author>Prerna Preeti</author>
public class PreserveScore : MonoBehaviour {
	
	/// <summary>
	/// Initializes the score when next level is reached by fetching the score
	/// stored from the previous level
	/// </summary>
	void Start () {
		TextMesh score = GameObject.Find("ScoreVal").GetComponent<TextMesh>();
		score.text=PlayerPrefs.GetString ("Points");
	}
	
	// Update is called once per frame
	void Update () {}
}
