using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonPool : MonoBehaviour {

	public static CommonPool instance;

	public List<GameObject> objects;
	public List<List<GameObject>> spawnedObjects = new List<List<GameObject>>();

	void Awake(){
	
		if (instance == null)
			instance = this;

		spawnedObjects.Add (new List<GameObject>());
		spawnedObjects.Add (new List<GameObject>());
		spawnedObjects.Add (new List<GameObject>());
		spawnedObjects.Add (new List<GameObject>());
		spawnedObjects.Add (new List<GameObject>());
	
	}

	public GameObject GetObject(int objectID){
	
		foreach (GameObject go in spawnedObjects[objectID]) {
		
			if(!go.activeSelf){
				go.SetActive (true);
				return go;
			}

		}

		GameObject newObj = Instantiate(objects[objectID]) as GameObject;
		spawnedObjects[objectID].Add(newObj);
		return newObj;
	
	}

}
