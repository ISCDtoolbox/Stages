using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCableButton_c : MonoBehaviour 
{
	private Get4Points_c get4PointsScript;

	void Start()
	{
		get4PointsScript = GameObject.FindGameObjectWithTag ("GameController").GetComponent<Get4Points_c> ();
		get4PointsScript.enabled = false;
	}

	void Update()
	{


	}
	public void TaskOnClickCableButton()
	{
		get4PointsScript.enabled = true;
		Get4Points_c.canDrawCable = false;
		Get4Points_c.canRayCast = true;
		Get4Points_c.cableDrawn = false;
		Get4Points_c.cableModif = false;
		Get4Points_c.cableCont = false;

//		Debug.Log ("TaskOnClick function called");
	}

	public void TaskOnClickCableContinueButton()
	{
		get4PointsScript.enabled = true;
		Get4Points_c.canDrawCable = false;
		Get4Points_c.canRayCast = true;
		Get4Points_c.cableDrawn = false;
		Get4Points_c.cableModif = false;
		Get4Points_c.cableCont = true;
		
	}
}
