using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour {

	EnemyMove enemyMove;
	void Start () {
		enemyMove = transform.parent.gameObject.GetComponent<EnemyMove> ();
	}
	void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			enemyMove.StartCoroutine("StartFire");
		}
	}
	void OnTriggerExit(Collider other){

		if (other.tag == "Player") {
			enemyMove.StopCoroutine("StartFire");
		}
	}
	void OnTriggerStay(Collider other){
		if (other.tag == "Player") {
			Debug.Log ("Player is nearby");
			transform.parent.LookAt (other.transform.position);
			enemyMove.nav.SetDestination (other.transform.position);
		}
	}
}
