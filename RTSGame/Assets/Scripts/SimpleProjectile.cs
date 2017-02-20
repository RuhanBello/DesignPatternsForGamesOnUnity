using UnityEngine;
using System.Collections;

public class SimpleProjectile : MonoBehaviour {

	public Vector3 target;

	private float speed = 5;

	void Start(){

		target = new Vector3 (target.x, 0.7f, target.z);
		transform.LookAt (target);

	}

	// Update is called once per frame
	void Update () {

		transform.Translate (Vector3.forward * speed * Time.deltaTime);
	
	}

}
