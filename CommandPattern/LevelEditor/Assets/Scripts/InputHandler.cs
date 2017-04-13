using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InputHandler : MonoBehaviour {

	public GameObject myObject;

	private Stack<ICommand> commands = new Stack<ICommand>();
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast (ray, out hit, Mathf.Infinity, 1 << 8)) {
		
				EditCommand command = new EditCommand (myObject, hit.point.x, hit.point.z);
				command.Execute ();

				commands.Push (command);
		
			}
	
		}

		if (Input.GetMouseButtonDown (1) && commands.Count > 0) {
		
			commands.Pop ().Undo();
		
		}

	}

}
