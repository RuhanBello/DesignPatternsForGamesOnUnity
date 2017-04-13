using UnityEngine;
using System.Collections;

public class CommandsData : MonoBehaviour {

	public static CommandsData instance;

	//Move action
	public float h;
	public float v;

	//Attack action
	public Vector3 target;

	void Awake(){

		if (instance == null)
			instance = this;

	}

}
