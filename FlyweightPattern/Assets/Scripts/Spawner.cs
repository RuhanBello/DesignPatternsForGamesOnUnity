using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	private int step = 0;
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.S)) {

			if (step == 0) {
				CommonPool.instance.GetObject (0).transform.position = new Vector3(-2, 0, 0);
				CommonPool.instance.GetObject (0).transform.position = new Vector3(-1, 0, 0);
				CommonPool.instance.GetObject (1).transform.position = new Vector3(0, 0, 0);
				CommonPool.instance.GetObject (2).transform.position = new Vector3(1, 0, 0);
				CommonPool.instance.GetObject (3).transform.position = new Vector3(2, 0, 0);
				step++;
			}else if (step == 1) {
				CommonPool.instance.GetObject (0).transform.position = new Vector3(-2, 0, 0);
				CommonPool.instance.GetObject (0).transform.position = new Vector3(-1, 0, 0);
				CommonPool.instance.GetObject (0).transform.position = new Vector3(0, 0, 0);
				CommonPool.instance.GetObject (1).transform.position = new Vector3(1, 0, 0);
				CommonPool.instance.GetObject (1).transform.position = new Vector3(2, 0, 0);
				step++;
			}else if (step == 2) {
				CommonPool.instance.GetObject (4).transform.position = new Vector3(-2, 0, 0);
				CommonPool.instance.GetObject (4).transform.position = new Vector3(-1, 0, 0);
				CommonPool.instance.GetObject (4).transform.position = new Vector3(0, 0, 0);
				CommonPool.instance.GetObject (4).transform.position = new Vector3(1, 0, 0);
				CommonPool.instance.GetObject (4).transform.position = new Vector3(2, 0, 0);
				step++;
			}

		}

	}

}
