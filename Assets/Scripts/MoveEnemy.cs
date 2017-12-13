using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class handles logic to move the enemy in particular orientation
/// </summary>
/// <author>Prerna Preeti</author>
public class MoveEnemy : MonoBehaviour {
	public Transform[] points;
	public float moveSpeed;
	private int currPt;
	
	/// <summary>
	/// Initializes the starting position of the enemy
	/// </summary>
	void Start () {
		transform.position = points [0].position;
		currPt = 0;
	}
	
	/// <summary>
	/// Updates the position of the enemy once per frame
	/// </summary>
	void Update () {
		if (transform.position == points [currPt].position) {
			currPt++;
		}
		if (currPt >= points.Length) {
			currPt = 0;
		}

		transform.position = Vector3.MoveTowards (transform.position, points [currPt].position, moveSpeed * Time.deltaTime);
	}
}
