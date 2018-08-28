/* This script shoulld be atttached to Exit points so as to instantiate colliders */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collider_Instantiate : MonoBehaviour
{
	public GameObject collider_cube;
	private GameObject coll;

	void Start () 
	{
		coll = Instantiate (collider_cube, this.transform.position, Quaternion.identity);	// at the very begining of the game colliders are instantiated at the Exit points 
		coll.gameObject.AddComponent<Collider_Script> (); // same time Collider_Script is added to the gameObject
	}
	
	void Update () 
	{
		coll.transform.position = this.transform.position; // when the exit points are moved (ie., when the gameObject is moved) the collider also moves accordingly 
		coll.transform.forward = this.transform.forward; // corresponding rotation is also followed by the colliders
	}
}
