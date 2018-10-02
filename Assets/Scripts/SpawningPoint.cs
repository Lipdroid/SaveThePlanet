using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningPoint : MonoBehaviour {
	public GameObject[] spawningObjects;

	// Use this for initialization
	void Start () {
		int rand = Random.Range (0, spawningObjects.Length);
//		GameObject spawningObject = Instantiate (spawningObjects [rand], transform.position, Quaternion.identity);
//		spawningObject.transform.parent = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
