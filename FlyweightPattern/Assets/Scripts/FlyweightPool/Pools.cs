using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pools : MonoBehaviour {

	public static class Fly_SpriteRenderer{

		private static readonly Smooth.Pools.Pool<SpriteRenderer> instance = new Smooth.Pools.Pool<SpriteRenderer>(
			() =>{  
				
				var go = new GameObject();
				return go.AddComponent<SpriteRenderer>();

			},
			sr =>{
				
				sr.sprite = null;
				sr.color = Color.white;
				sr.transform.parent = null;

			}

		);

		public static Smooth.Pools.Pool<SpriteRenderer> Instance {get { return instance;} }

	}

	public static class Fly_BoxCollider2D{

		private static readonly Smooth.Pools.Pool<BoxCollider2D> instance = new Smooth.Pools.Pool<BoxCollider2D>(
			() =>{  

				var go = new GameObject();
				return go.AddComponent<BoxCollider2D>();

			},
			bc =>{

				bc.transform.parent = null;

			}

		);

		public static Smooth.Pools.Pool<BoxCollider2D> Instance {get { return instance;} }

	}

}
