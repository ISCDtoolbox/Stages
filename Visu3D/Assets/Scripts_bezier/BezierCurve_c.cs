using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(LineRenderer))]

public class BezierCurve_c
{
	public static Vector3 firstPoint, secondPoint, thirdPoint, fourthPoint;
	private LineRenderer lineRenderer;
	private int numPoints = 100;
	private Vector3[] positions = new Vector3[100];

	public BezierCurve_c ( Vector3 fP,Vector3 sP,Vector3 tP,Vector3 frP)
	{
		firstPoint = fP;
		secondPoint = sP;
		thirdPoint = tP;
		fourthPoint = frP;

		lineRenderer = new LineRenderer ();
		lineRenderer =new GameObject().AddComponent<LineRenderer> ();
		lineRenderer.positionCount = numPoints;
		lineRenderer.material = GameObject.FindGameObjectWithTag ("cable_wire").GetComponent<Renderer> ().material;
	}

	public void DrawCurve()
	{
		for (int i = 1; i < numPoints + 1; i++) 
		{
			float t = i / (float)numPoints;
			positions [i - 1] = CalculateCubicBezierPoint (t,firstPoint , secondPoint, thirdPoint, fourthPoint);


			Ray rayN = Camera.main.ScreenPointToRay (positions [i - 1]);
			RaycastHit hitN;
			Physics.Raycast (rayN , out hitN);
			float offset = hitN.point.z;
			Debug.Log ("offset: " + offset);
			positions [i - 1].z = -hitN.distance + offset;
		}
		lineRenderer.SetPositions (positions);
	}

	private Vector3 CalculateCubicBezierPoint(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3)
	{
		float u = 1 - t;
		float tt = t * t;
		float uu = u * u;
		float uuu = uu * u;
		float ttt = tt * t;
		Vector3 p = uuu * p0;
		p += 3 * uu * t * p1;
		p += 3 * u * tt * p2;
		p += ttt * p3;

//		Debug.Log ("the value of p: " + p);
		return p;

	} 
}
