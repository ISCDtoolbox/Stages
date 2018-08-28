/*
This script Raycasts from the GameObject to which it is attached
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_Script : MonoBehaviour 
{
	private Vector3 collPos;
	private GameObject hitObj;

	void Start()
	{
		
	}

	void Update () 
	{
		Ray ray = new Ray (this.transform.position, (Camera.main.transform.position - this.transform.position) );  // Ray is casted with Position equals to the position of the GameObject and Direction equals to the center of the screen ViewPort
		RaycastHit hit;
	
		if (Physics.Raycast (ray, out hit)) // if RayCast is successfull 
		{
			if (hit.transform.tag == "conduit") // chechs if the hit gameObject has a tag "conduit"
			{				
				hit.transform.position = this.transform.position; //the position of the hit gameObject is equals to this exit point position
				hit.transform.forward = this.transform.forward; // the rotation of the hit gameObject is equals to this exit point rotation
				hitObj = hit.transform.gameObject; // this hit gameObject is stored in gameObject hitObj 
//				Debug.Log ("old pos: " +this.transform.position); 
			} 
			else
			{
				
			}
		}

		if (hitObj && !Input.GetMouseButton(0)) // checks if hitObj exists and if Left Mouse Button is clicked
		{
			hitObj.transform.position = this.transform.position; // the position of the hit gameObject is equals to this exit point position
//			Debug.Log ("new pos: " +this.transform.position);
		}
				
		


	}
}
