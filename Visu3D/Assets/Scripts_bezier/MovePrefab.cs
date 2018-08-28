using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePrefab : MonoBehaviour {

	private Vector3 MousePos, curPosition,posRelach;	
	private Vector3 screenSpace, offset;

	void Start ()
	{
		
	}
	
	void Update () 
	{
		
		
	}
	void OnMouseDown()
	{
		this.gameObject.GetComponent<Renderer> ().material.SetColor ("_Color", Color.red);
		screenSpace = Camera.main.WorldToScreenPoint (this.transform.position);
		offset = this.transform.position - Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenSpace.z));
		posRelach = Input.mousePosition;
	}

	void OnMouseUp()
	{
		this.gameObject.GetComponent<Renderer> ().material.SetColor ("_Color", Color.green);

		this.transform.position = new Vector3 (curPosition.x, curPosition.y, curPosition.z);
	}

	void OnMouseDrag()
	{
		this.gameObject.GetComponent<Renderer> ().material.SetColor ("_Color", Color.red);

		MousePos = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, screenSpace.z);
		curPosition = Camera.main.ScreenToWorldPoint (MousePos) + offset;
		this.transform.position = curPosition;
	}
}
