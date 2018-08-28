/*
This script is used to move the gameObject with respect to the mouse pointer position
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manip_Imports : MonoBehaviour
{
	Vector3 MousePos, cursorPos, screenSpace;
	Vector3 objScale;
	public static bool manipobj;

	void Start()
	{
		manipobj = false; // no object is manipulated at the begining thus false
	}

	void OnMouseDrag() // when the user clicks the object (left mouse button)
	{
		manipobj = true; // now a object is being manipulated by the user thus true
		MousePos = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 30.0f); // retrives the mouse position in 3D world coordinates
		cursorPos = Camera.main.ScreenToWorldPoint (MousePos); // converts the 3D mouse position in worldcoordinates to 2D coordinates
		this.transform.position = cursorPos; // this position is applied to the manipulated object
	}

	void OnMouseUp() // when the user releases the click
	{
		manipobj = false; // no object being manipulated thus false
	}
}
