using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbitor : MonoBehaviour {

	public GameObject pivotObject;
	public float speed;
	public float angle;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.RotateAround (pivotObject.transform.position, Vector3.back, speed * Time.deltaTime);
	}
}
