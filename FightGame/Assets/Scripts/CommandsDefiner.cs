using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Commands;

public class CommandsDefiner : MonoBehaviour {

	public PlayerInput playerInput;

	public void SpaceDefiner(string command){
	
		if (command == "WalkLeft") {
			if (playerInput.singleInputs.Remove (KeyCode.Space)) {
				playerInput.continuousInputs.Add (KeyCode.Space, new MoveLeftCommand());
			} else
				playerInput.continuousInputs [KeyCode.Space] = new MoveLeftCommand ();
		}

		if (command == "WalkRight") {
			if (playerInput.singleInputs.Remove (KeyCode.Space)) {
				playerInput.continuousInputs.Add (KeyCode.Space, new MoveRightCommand());
			} else
				playerInput.continuousInputs [KeyCode.Space] = new MoveRightCommand ();
		}

		if (command == "Jump") {
			if (playerInput.continuousInputs.Remove (KeyCode.Space)) {
				playerInput.singleInputs.Add (KeyCode.Space, new JumpCommand());
			} else
				playerInput.singleInputs [KeyCode.Space] = new JumpCommand();
		}

		if (command == "Attack") {
			if (playerInput.continuousInputs.Remove (KeyCode.Space)) {
				playerInput.singleInputs.Add (KeyCode.Space, new AttackCommand());
			} else
				playerInput.singleInputs [KeyCode.Space] = new AttackCommand();
		}

	}

	public void ADefiner(string command){

		if (command == "WalkLeft") {
			if (playerInput.singleInputs.Remove (KeyCode.A)) {
				playerInput.continuousInputs.Add (KeyCode.A, new MoveLeftCommand());
			} else
				playerInput.continuousInputs [KeyCode.A] = new MoveLeftCommand ();
		}

		if (command == "WalkRight") {
			if (playerInput.singleInputs.Remove (KeyCode.A)) {
				playerInput.continuousInputs.Add (KeyCode.A, new MoveRightCommand());
			} else
				playerInput.continuousInputs [KeyCode.A] = new MoveRightCommand ();
		}

		if (command == "Jump") {
			if (playerInput.continuousInputs.Remove (KeyCode.A)) {
				playerInput.singleInputs.Add (KeyCode.A, new JumpCommand());
			} else
				playerInput.singleInputs [KeyCode.A] = new JumpCommand();
		}

		if (command == "Attack") {
			if (playerInput.continuousInputs.Remove (KeyCode.A)) {
				playerInput.singleInputs.Add (KeyCode.A, new AttackCommand());
			} else
				playerInput.singleInputs [KeyCode.A] = new AttackCommand();
		}

	}

	public void LeftDefiner(string command){

		if (command == "WalkLeft") {
			if (playerInput.singleInputs.Remove (KeyCode.LeftArrow)) {
				playerInput.continuousInputs.Add (KeyCode.LeftArrow, new MoveLeftCommand());
			} else
				playerInput.continuousInputs [KeyCode.LeftArrow] = new MoveLeftCommand ();
		}

		if (command == "WalkRight") {
			if (playerInput.singleInputs.Remove (KeyCode.LeftArrow)) {
				playerInput.continuousInputs.Add (KeyCode.LeftArrow, new MoveRightCommand());
			} else
				playerInput.continuousInputs [KeyCode.LeftArrow] = new MoveRightCommand ();
		}

		if (command == "Jump") {Debug.Log ("What?!");
			if (playerInput.continuousInputs.Remove (KeyCode.LeftArrow)) {
				playerInput.singleInputs.Add (KeyCode.LeftArrow, new JumpCommand());
			} else
				playerInput.singleInputs [KeyCode.LeftArrow] = new JumpCommand();
		}

		if (command == "Attack") {
			if (playerInput.continuousInputs.Remove (KeyCode.LeftArrow)) {
				playerInput.singleInputs.Add (KeyCode.LeftArrow, new AttackCommand());
			} else
				playerInput.singleInputs [KeyCode.LeftArrow] = new AttackCommand();
		}

	}

	public void RightDefiner(string command){

		if (command == "WalkLeft") {
			if (playerInput.singleInputs.Remove (KeyCode.RightArrow)) {
				playerInput.continuousInputs.Add (KeyCode.RightArrow, new MoveRightCommand());
			} else
				playerInput.continuousInputs [KeyCode.RightArrow] = new MoveLeftCommand ();
		}

		if (command == "WalkRight") {
			if (playerInput.singleInputs.Remove (KeyCode.RightArrow)) {
				playerInput.continuousInputs.Add (KeyCode.RightArrow, new MoveRightCommand());
			} else
				playerInput.continuousInputs [KeyCode.RightArrow] = new MoveRightCommand ();
		}

		if (command == "Jump") {
			if (playerInput.continuousInputs.Remove (KeyCode.RightArrow)) {
				playerInput.singleInputs.Add (KeyCode.RightArrow, new JumpCommand());
			} else
				playerInput.singleInputs [KeyCode.RightArrow] = new JumpCommand();
		}

		if (command == "Attack") {
			if (playerInput.continuousInputs.Remove (KeyCode.RightArrow)) {
				playerInput.singleInputs.Add (KeyCode.RightArrow, new AttackCommand());
			} else
				playerInput.singleInputs [KeyCode.RightArrow] = new AttackCommand();
		}

	}

}
