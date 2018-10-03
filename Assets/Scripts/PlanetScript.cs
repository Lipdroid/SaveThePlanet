using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetScript : MonoBehaviour {

	public float speed;
	public float angle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//ratate the planet all the time
		transform.Rotate(new Vector3(0,0,-angle) * speed * Time.deltaTime);
	}
	void OnMouseOver(){
		Debug.Log ("Mouse is on a planet");
	}
}
