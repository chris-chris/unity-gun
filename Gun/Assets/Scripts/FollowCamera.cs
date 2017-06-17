using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour {

	public Transform target;
	public float distanceUp = 8f;
	public float distanceAway = -12f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = new Vector3 (
			target.position.x, 
			target.position.y + distanceUp,
			target.position.z + distanceAway
		);

	}
}
