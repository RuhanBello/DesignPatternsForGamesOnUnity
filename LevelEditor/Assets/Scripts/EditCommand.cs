using UnityEngine;
using System.Collections;

public class EditCommand : ICommand {

	private GameObject newObj;
	private GameObject myObj;
	private float xPosition;
	private float zPosition;

	public EditCommand(GameObject newObject, float x, float z){
	
		newObj = newObject;
		xPosition = x;
		zPosition = z;
	
	}

	public void Execute(){

		myObj = (GameObject.Instantiate (newObj, new Vector3(xPosition, 0, zPosition), Quaternion.Euler(0, Random.Range(0, 360), 0))as GameObject);

	}

	public void Undo(){

		GameObject.Destroy (myObj);

	}

}
