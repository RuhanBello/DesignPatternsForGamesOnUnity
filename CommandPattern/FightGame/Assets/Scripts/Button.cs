using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	public KeyCode key;
	public ICommand command;

	public Button (KeyCode newKey, ICommand newCommand){
	
		key = newKey;
		command = newCommand;
	
	}

}
