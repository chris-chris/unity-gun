using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour {

	public NavMeshAgent nav;

	void Start(){

		nav = GetComponent<NavMeshAgent> ();
		
	}

	public Transform gunEnd;

	public IEnumerator StartFire(){

		while (true) {

			GameObject bullet = Resources.Load ("Prefabs/Bullet") as GameObject;
			GameObject obj = Instantiate (bullet, gunEnd.position, gunEnd.rotation);

			obj.GetComponent<Rigidbody> ().AddForce (transform.forward * 1000f);

			yield return new WaitForSeconds (0.5f);
		
		}

	}
}
