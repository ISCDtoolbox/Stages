using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe_pivote : MonoBehaviour 
{
	private Vector3 colliderSize, colliderCenter;

	void Awake () 
	{
		colliderSize = this.gameObject.GetComponent<BoxCollider> ().size;
		colliderCenter = this.gameObject.GetComponent<BoxCollider> ().center;
	}
	
	void Update () 
	{
		this.gameObject.GetComponent<BoxCollider> ().size = colliderSize;
		this.gameObject.GetComponent<BoxCollider> ().center = colliderCenter;
	}
}
