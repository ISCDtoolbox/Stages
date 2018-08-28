using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshNormalCalc : MonoBehaviour
{
//	public GameObject ossature;
//	private Mesh ossatureMesh;
//	private Collider ossatureCollider;
//	private Vector3[] ossatureNormals;
//
//	void Start () 
//	{
//		ossatureMesh = ossature.gameObject.GetComponent<MeshFilter> ().mesh;
//		ossatureNormals = ossatureMesh.normals;
//
//	}
//	
	void Update () 
	{
		if (Input.GetMouseButtonDown (0))
		{
			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			Physics.Raycast (ray);
			Debug.DrawRay(ray.origin, ray.direction, Color.yellow);
			Debug.Log ("Test raycast ray: " +ray);
		}
	}



}
