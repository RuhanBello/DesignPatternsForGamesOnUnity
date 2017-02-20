using UnityEngine;
using System.Collections;
using Commands;

public class PlayerInput : MonoBehaviour {

	public ICommand arrowsButtons;
	public ICommand rightButton;
	public UnitsController unitsController;

	void Start(){

		arrowsButtons = new MoveCommand ();
		rightButton = new AttackCommand ();

	}

	void Update(){

		if (unitsController.selecting)
			return;

		Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit)) {

			if (Input.GetMouseButtonDown (1)) {
				CommandsData.instance.target = hit.point;
				unitsController.HandleCommand (rightButton);

			}

		}

		CommandsData.instance.h = Input.GetAxisRaw ("Horizontal");
		CommandsData.instance.v = Input.GetAxisRaw ("Vertical");

		unitsController.HandleCommand (arrowsButtons);

	}

}
