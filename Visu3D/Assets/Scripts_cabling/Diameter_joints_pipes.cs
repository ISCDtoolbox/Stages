using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diameter_joints_pipes : MonoBehaviour 
{
	public float size;
	private float currentSize;

	void Start () 
	{
		size = 1.0f;		
	}
	
	void Update () 
	{
		if (currentSize != size) 
		{
			this.transform.localScale *= size;
		}
		currentSize = size;
		
	}
}
