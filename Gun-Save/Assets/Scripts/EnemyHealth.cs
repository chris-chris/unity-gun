using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

	public int Health = 100;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnDamage(int amount){

		Health = Health - amount;

		if (Health <= 0) {
			Debug.Log ("Die");
			Destroy (gameObject);
		}

	}

}
