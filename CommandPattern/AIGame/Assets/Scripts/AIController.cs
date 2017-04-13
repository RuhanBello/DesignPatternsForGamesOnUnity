using UnityEngine;
using System.Collections;
using Commands;

//[RequireComponent (typeof(PlayerActions))]
public class AIController : MonoBehaviour {

	public ICommand space;
	public ICommand enter;
	public ICommand left;
	public ICommand right;

	private Actions playerActions;
	private bool isJumping = false;

	void Awake(){

		playerActions = GetComponent<Actions> ();

		space = new JumpCommand();
		enter = new AttackCommand ();
		left = new MoveLeftCommand ();
		right = new MoveRightCommand ();

	}

	// Use this for initialization
	void Start () {

		StartCoroutine (GenerateCommand());

	}

	IEnumerator GenerateCommand(){

		yield return new WaitForSeconds (2);

		int randomCommand = Random.Range (0, 2);

		if (randomCommand == 0) {
			left.Execute (playerActions);
		}

		if (randomCommand == 1) {
			right.Execute (playerActions);
		}

		StartCoroutine (GenerateCommand());

	}

	void OnTriggerEnter(Collider c){

		if (c.name.Contains ("Projectile") && !isJumping) {
			StartCoroutine (Jump());
		}

	}

	IEnumerator Jump(){

		isJumping = true;
		space.Execute (playerActions);

		yield return new WaitForSeconds (1);

		isJumping = false;

	}

}
