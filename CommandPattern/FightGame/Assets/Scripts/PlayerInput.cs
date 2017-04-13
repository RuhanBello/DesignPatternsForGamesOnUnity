using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Commands;

[RequireComponent (typeof(Actions))]
public class PlayerInput : MonoBehaviour {

	public Dictionary<KeyCode, ICommand> singleInputs = new Dictionary<KeyCode, ICommand>();
	public Dictionary<KeyCode, ICommand> continuousInputs = new Dictionary<KeyCode, ICommand>();

	private Actions actions;

	void Awake(){
		
		actions = GetComponent<Actions> ();

		singleInputs.Add (KeyCode.Space, new JumpCommand());
		singleInputs.Add (KeyCode.A, new AttackCommand());
		continuousInputs.Add (KeyCode.LeftArrow, new MoveLeftCommand());
		continuousInputs.Add (KeyCode.RightArrow, new MoveRightCommand());

	}

	// Update is called once per frame
	void Update () {

		ICommand command = HandleInput ();

		if (command != null)
			command.Execute ();

	}

	ICommand HandleInput(){

		foreach (var entry in singleInputs) {
		
			if (Input.GetKeyDown (entry.Key))
				return entry.Value;
		
		}

		foreach (var entry in continuousInputs) {
			
			if (Input.GetKey (entry.Key))
				return entry.Value;

		}

		return null;
	
	}

}
