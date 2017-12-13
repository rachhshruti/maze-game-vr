using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreserveScore : MonoBehaviour {
	// Use this for initialization
	void Start () {
		TextMesh score = GameObject.Find("ScoreVal").GetComponent<TextMesh>();
		score.text=PlayerPrefs.GetString ("Points");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
