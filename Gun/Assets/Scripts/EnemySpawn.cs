using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (StartSpawn ());
	}

	IEnumerator StartSpawn(){
		while (true) {
			int idx = Random.Range (0, transform.childCount);
			Transform spawnLoc = transform.GetChild (idx);

			Instantiate (Resources.Load ("Prefabs/Enemy") as GameObject, spawnLoc.position, spawnLoc.rotation);

			yield return new WaitForSeconds (5f);
		}
	}

}
