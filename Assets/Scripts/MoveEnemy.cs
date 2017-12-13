using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour {
	public Transform[] points;
	public float moveSpeed;
	private int currPt;
	// Use this for initialization
	void Start () {
		transform.position = points [0].position;
		currPt = 0;
	}
	
	// Update is called once per frame
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
