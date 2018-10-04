using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour {
	public GameObject effect;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnMouseEnter() 
	{
		//transform.localScale += new Vector3(0.1F, 0, 0);
	}

	public void OnMouseOver()
	{
		Debug.Log ("Create pulse animation");
		//gameObject.transform.position = new Vector3(Mathf.PingPong(Time.time, 3), Mathf.PingPong(Time.time, 3), 0);
		Instantiate (effect, transform.position, Quaternion.identity);
		Destroy(gameObject);
	}

	public void OnMouseExit()
	{
		//transform.localScale += new Vector3(0F, 0, 0);    
	}


}
