using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UnitsController : MonoBehaviour {

	public List<GameObject> selectedObjects;
	public bool selecting = true;
	public GameObject selectingText;

	void Update(){

		if (Input.GetKeyDown (KeyCode.Space)) {
			selecting = !selecting;
			selectingText.SetActive (!selectingText.activeSelf);
		}

		if (!selecting)
			return;
		
		if (Input.GetMouseButtonDown (0)) {
		
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			RaycastHit hit;

			if (Physics.Raycast (ray, out hit, Mathf.Infinity, 1 << 8)) {

				Selectable s = hit.collider.GetComponent<Selectable> ();

				if (!s.isSelected) {
					s.isSelected = true;
					selectedObjects.Add (hit.collider.gameObject);
				} else {
					s.isSelected = false;
					selectedObjects.Remove (hit.collider.gameObject);
				}

			}

		}

	}

	public void HandleCommand(ICommand command){
	
		foreach (GameObject go in selectedObjects) {

			command.Execute (go);
		
		}
	
	}

}
