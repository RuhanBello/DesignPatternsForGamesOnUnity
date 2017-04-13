using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	public Sprite mySprite;

	GameObject myObj;
	GameObject spriteRendererObj;
	GameObject boxColliderObj;

	void Awake(){

		myObj = new GameObject ();

	}

	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown(KeyCode.B)){

			spriteRendererObj = Pools.Fly_SpriteRenderer.Instance.Borrow().gameObject;
			spriteRendererObj.transform.parent = myObj.transform;
			spriteRendererObj.transform.localPosition = Vector3.zero;
			spriteRendererObj.GetComponent<SpriteRenderer> ().sprite = mySprite;

			boxColliderObj = Pools.Fly_BoxCollider2D.Instance.Borrow().gameObject;
			boxColliderObj.transform.parent = myObj.transform;
			boxColliderObj.transform.localPosition = Vector3.zero;

		}

		if (Input.GetKeyDown (KeyCode.R)) {

			Pools.Fly_SpriteRenderer.Instance.Release (spriteRendererObj.GetComponent<SpriteRenderer>());
			Pools.Fly_BoxCollider2D.Instance.Release (boxColliderObj.GetComponent<BoxCollider2D>());

		}
		
	}
}
