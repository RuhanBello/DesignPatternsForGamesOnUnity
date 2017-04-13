using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeObject : MonoBehaviour {

	public Sprite mySprite;

	GameObject myObj;
	GameObject spriteRendererObj;
	GameObject boxColliderObj;

	// Use this for initialization
	void OnEnable () {

		StartCoroutine (Deactivate());

		spriteRendererObj = Pools.Fly_SpriteRenderer.Instance.Borrow().gameObject;
		spriteRendererObj.transform.parent = transform;
		spriteRendererObj.transform.localPosition = Vector3.zero;
		spriteRendererObj.GetComponent<SpriteRenderer> ().sprite = mySprite;

		boxColliderObj = Pools.Fly_BoxCollider2D.Instance.Borrow().gameObject;
		boxColliderObj.transform.parent = transform;
		boxColliderObj.transform.localPosition = Vector3.zero;
		
	}

	void DisableComponents () {

		Pools.Fly_SpriteRenderer.Instance.Release (spriteRendererObj.GetComponent<SpriteRenderer>());
		Pools.Fly_BoxCollider2D.Instance.Release (boxColliderObj.GetComponent<BoxCollider2D>());

	}

	IEnumerator Deactivate(){

		yield return new WaitForSeconds (1);

		DisableComponents ();

		gameObject.SetActive (false);

	}

}
