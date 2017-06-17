using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMove : MonoBehaviour {

	public Transform gunEnd;
	public GameObject mainCamera;

	public float speed = 10.0F;
	public float rotationSpeed = 100.0F;
	void Update() {
		float translation = Input.GetAxis("Vertical") * speed;
		float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
		translation *= Time.deltaTime;
		rotation *= Time.deltaTime;
		transform.Translate(0, 0, translation);
		transform.Rotate(0, rotation, 0);

		if (Input.GetButton ("Fire1")) {
			GameObject bullet = Resources.Load ("Prefabs/Bullet") as GameObject;
			GameObject obj = Instantiate (bullet, gunEnd.position, gunEnd.rotation);

			obj.GetComponent<Rigidbody> ().AddForce (transform.forward * 1000f);

			mainCamera.GetComponent<AudioSource> ().PlayOneShot (Resources.Load ("Audio/explosion_enemy") as AudioClip);

		}

		Ray ray = mainCamera.GetComponent<Camera> ().ScreenPointToRay (Input.mousePosition);

		//Debug.DrawRay (ray.origin, ray.direction,Color.red);

		RaycastHit hit;
		if (Physics.Raycast (ray, out hit)) {

			Debug.DrawLine (ray.origin, hit.point, Color.red);

			if (Input.GetMouseButton (0)) {
				GetComponent<NavMeshAgent> ().SetDestination (hit.point);
			}

		}


	}
}
