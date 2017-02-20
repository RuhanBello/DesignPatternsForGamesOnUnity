using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Commands;

[RequireComponent (typeof(Actions))]
public class PlayerInput : MonoBehaviour {

	public ICommand spaceButton;
	public ICommand AButton;
	public ICommand leftButton;
	public ICommand rightButton;

	private Actions actions;

	void Awake(){
		
		actions = GetComponent<Actions> ();

		spaceButton = new JumpCommand();
		AButton = new AttackCommand ();
		leftButton = new MoveLeftCommand ();
		rightButton = new MoveRightCommand ();

	}

	// Update is called once per frame
	void Update () {

		ICommand command = HandleInput ();

		if (command != null)
			command.Execute (actions);

	}

	ICommand HandleInput(){

		if (Input.GetKeyDown (KeyCode.Space))
			return spaceButton;

		if (Input.GetKeyDown (KeyCode.A))
			return AButton;

		if (Input.GetKey (KeyCode.LeftArrow))
			return leftButton;

		if (Input.GetKey (KeyCode.RightArrow))
			return rightButton;

		return null;
	
	}

}
