using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Get4Points_c : MonoBehaviour 
{
	private int i;
	private Vector3 hitPoint, hitPoint1, hitPoint2, hitPoint3, hitPoint4, hitNormal;
	private GameObject[] h_prefabObj;
	private GameObject h_prefabObjTemp;

	public GameObject h_prefab;
	public BezierCurve_c bezierCurveScript;


	public static bool canDrawCable, canRayCast, cableDrawn, cableModif, cableCont;

	void Start () 
	{
		i = 0;
		h_prefabObj = new GameObject[4];
		canDrawCable = false;
		canRayCast = true;
		cableDrawn = false;
		cableModif = false;
		cableCont = false;
	}
	
	void Update () 
	{
		if (Input.GetMouseButtonDown (0) && i<=4 && canRayCast && !canDrawCable) 
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 
			RaycastHit hit;

//			Debug.Log ("MousePostion: " + Input.mousePosition);
//			Debug.Log ("Ray: " + ray);


			if (Physics.Raycast(ray, out hit) && i<4) 
			{
				hitPoint = hit.point;
				hitNormal = hit.normal;
//				Debug.Log ("Hitpoint normal: " + hitNormal);

				Vector3 refVec = Vector3.Reflect (hitPoint, hit.normal);
				Debug.DrawLine (hitPoint, refVec, Color.green);


				if (i == 0 && !cableCont) 
				{
					hitPoint1 = hitPoint;
					h_prefabObj [0] = Instantiate (h_prefab, hitPoint1, Quaternion.identity);
				}else if (i == 0 && cableCont) 
					{
						h_prefabObj [0] = h_prefabObjTemp;
						cableCont = false;
					}

				if (i == 1) 
				{
					hitPoint2 = hitPoint;
					h_prefabObj[1] = Instantiate (h_prefab, hitPoint2, Quaternion.identity);
				}
				if (i == 2) 
				{
					hitPoint3 = hitPoint;
					h_prefabObj[2] = Instantiate (h_prefab, hitPoint3, Quaternion.identity);
				}
				if (i == 3) 
				{
					hitPoint4 = hitPoint;
					h_prefabObj[3] = Instantiate (h_prefab, hitPoint4, Quaternion.identity);
					h_prefabObjTemp = h_prefabObj [3];
				}
			} //if (RayCast)
			i += 1;

			if (i == 4) 
			{
				canDrawCable = true;
				canRayCast = false;
				i = 0;
			}
		} //if (getMouseButton)

		if (canDrawCable && !cableDrawn) 
		{
			Debug.Log ("Drawing cable");
			bezierCurveScript = new BezierCurve_c (h_prefabObj[0].transform.position, h_prefabObj[1].transform.position, h_prefabObj[2].transform.position, h_prefabObj[3].transform.position);

			bezierCurveScript.DrawCurve ();
			cableDrawn = true;
			cableModif = true;

		}

		if (cableDrawn && cableModif) 
		{
//			Debug.Log ("In cable Modify");
			BezierCurve_c.firstPoint = h_prefabObj [0].transform.position;
			BezierCurve_c.secondPoint = h_prefabObj [1].transform.position;
			BezierCurve_c.thirdPoint = h_prefabObj [2].transform.position;
			BezierCurve_c.fourthPoint = h_prefabObj [3].transform.position;
			bezierCurveScript.DrawCurve ();
		}
			
	} //Update

}
