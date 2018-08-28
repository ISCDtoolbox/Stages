/*
This script increments or decrements the size of the pipe gameobject with right mouse button pressed and dragged
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaling_pipe : MonoBehaviour 
{
	private Vector3 tempScale, curObjPos, curMousPos, objScale, offset;
	public bool scalingActivated;

	private Vector3 childScale;

	void Start()
	{
		scalingActivated = false; // at the beginning no scaling is done
	}

	void OnMouseDown() // when left mouse button is clicked over the gameobject
	{ 
		curObjPos = this.gameObject.transform.position; // the position of the gameobject is stored in the curObjPos variable
		curMousPos = Camera.main.ScreenToWorldPoint (Input.mousePosition); // the 3D mouse position is converted to 2D coordinate and stored in curMousPos 
		offset = curObjPos - curMousPos; // an offset is added between the gameobject and the mouse
		objScale = this.gameObject.transform.localScale; // the present scale of the gameobject is stored in objScale variable
	}

	void OnMouseOver() // when the mouse is over the pipe gameobject *** not clicked ***
	{
		if (Input.GetMouseButtonDown (1)) // if right mouse button is clicked
		{
			scalingActivated = true; // now th scaling is activated
		}
	}

	void Update()
	{
		if (scalingActivated) // checks if the scaling is activated
		{
			objScale = new Vector3 (objScale.x, objScale.y, objScale.z + Input.GetAxis ("Mouse Y") * 50); // the movement of the mouse in Y axis calculated and converted into integer value
			this.gameObject.transform.localScale = objScale; // now this is applied to scale the pipe gameobject

//			childScale = this.gameObject.transform.GetComponentInChildren<Transform> ().localScale;
		}

		if (Input.GetMouseButtonUp (1)) // checks if the right mouse button is released
			scalingActivated = false; // scaling is now deactivated
	}
}
