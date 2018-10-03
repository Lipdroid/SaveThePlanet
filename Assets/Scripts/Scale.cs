using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour {
	
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

	}

	public void OnMouseExit()
	{
		//transform.localScale += new Vector3(0F, 0, 0);    
	}


}
