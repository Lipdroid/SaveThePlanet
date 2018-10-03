using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningPoint : MonoBehaviour {
	public GameObject[] spawningObjects;

	// Use this for initialization
	void Start () {
		int rand = Random.Range (0, spawningObjects.Length);
		Vector2 pos = new Vector2 (transform.position.x, transform.position.y);
		GameObject spawningObject = Instantiate (spawningObjects [rand], pos, transform.localRotation);
		spawningObject.transform.parent = this.transform;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseOver(){
		Debug.Log ("Mouse is on a spawnpoint");
	}
}
