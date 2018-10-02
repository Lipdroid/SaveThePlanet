using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSurfaceScript : MonoBehaviour {
	public float speed;
	public float angle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//ratate the spawnpoint all the time
		transform.Rotate(new Vector3( 0, 0, -angle) * speed * Time.deltaTime);

	}
}
