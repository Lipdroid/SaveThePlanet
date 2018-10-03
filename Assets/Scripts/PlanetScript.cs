using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetScript : MonoBehaviour {

	public float angle;
	public float interval;

	// Use this for initialization
	void Start () {
		StartCoroutine(RotateObject(angle, Vector3.back, interval));

	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnMouseOver(){
		Debug.Log ("Mouse is on a planet");
	}

	IEnumerator RotateObject(float angle, Vector3 axis, float inTime)
	{
		// calculate rotation speed
		float rotationSpeed = angle / inTime;

		while (true)
		{
			// save starting rotation position
			Quaternion startRotation = transform.rotation;

			float deltaAngle = 0;

			// rotate until reaching angle
			while (deltaAngle < angle)
			{
				deltaAngle += rotationSpeed * Time.deltaTime;
				deltaAngle = Mathf.Min(deltaAngle, angle);

				transform.rotation = startRotation * Quaternion.AngleAxis(deltaAngle, axis);

				yield return null;
			}

			// delay here
			yield return new WaitForSeconds(interval);
		}
	}
}
