using UnityEngine;
using System.Collections;

public class UnitActions : MonoBehaviour {

	public static UnitActions instance;

	public GameObject projectile;

	void Awake(){
	
		if (instance == null)
			instance = this;
	
	}

	public void Move(GameObject actor){

		actor.transform.Translate (new Vector3(CommandsData.instance.h * Time.deltaTime, 0, CommandsData.instance.v * Time.deltaTime));

	}

	public void Attack(GameObject actor){

		SimpleProjectile proj = (Instantiate (projectile, actor.transform.position, Quaternion.identity)as GameObject).GetComponent<SimpleProjectile>();
		proj.target = CommandsData.instance.target;

	}

}
