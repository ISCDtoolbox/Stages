/*
This script is used to have the pause and to move the camera
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class GameController : MonoBehaviour 
{

	public Transform player;

	int i;

	void Start ()
	{
		i = 1; // int i is by default 1
	}

	void Update () 
	{
		if (Input.GetKeyUp(KeyCode.Escape))		// If escape key is pressed
		{	
			Pause(); // the function Pause() is called
		}
		if(player.GetComponent<FirstPersonController>().enabled == false) // checks if the firstPersonController is not active
		{
			if (Input.GetKey (KeyCode.UpArrow)) { // checks if the up arrow is pressed
//				Debug.Log ("Up pressed");
				player.transform.position = new Vector3(player.transform.position.x,player.transform.position.y + 1.0f,player.transform.position.z); // the camera (player view) is moved upwards
			} else if (Input.GetKey (KeyCode.DownArrow)) { // checks if the down arrow is pressed
//				Debug.Log ("Down pressed");
				player.transform.position = new Vector3(player.transform.position.x,player.transform.position.y - 1.0f,player.transform.position.z); // the camera (payer view) is moved downwards
			}
		}
	}

	public void Pause() // this function enables/disables the pause
	{
		i = i + 1; // this i variable is incremented (by default i=1 (odd => no pause), for the first time when escape key is pressed i=2 (even => pause) and so on...)

		if (i%2==0) // if the total number of times the escape pressed is "even" then pause is executed
		{
			Time.timeScale = 0;		// Used to freeze the scene (no gravity, movement etc., but still the playerController is able to Look Around)
			player.GetComponent<FirstPersonController>().enabled = false;		// Freeze the PlayerController total movement
		}
		else // if the total number of times the escape pressed is "odd" then pause is executed
		{
			Time.timeScale = 1;		// time scale set to real time movement
			player.GetComponent<FirstPersonController>().enabled = true;  // PlayerController is enabled
		}
	}
}
