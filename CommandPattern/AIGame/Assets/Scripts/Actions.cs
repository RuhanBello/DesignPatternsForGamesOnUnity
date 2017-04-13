using UnityEngine;
using System.Collections;

public class Actions : MonoBehaviour {

	public GameObject projectile;

	private Rigidbody rgbd;
	private float jumpForce = 200;
	private float speed = 150;

	void Awake(){

		rgbd = GetComponent<Rigidbody> ();

	}

	public void Jump(){

		rgbd.AddForce (Vector3.up * jumpForce);

	}

	public void Attack(){
	
		Instantiate (projectile, transform.position, transform.rotation);
	
	}

	public void Move(int direction){

		rgbd.velocity = new Vector3 (speed * direction * Time.deltaTime, rgbd.velocity.y, rgbd.velocity.z);

	}

}
