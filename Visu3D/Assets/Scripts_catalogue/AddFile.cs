/* This script is used to Instantiate the Gameobject upon clicking the "+" button,
 * the object instantiated corresponds to the Gameobject on the "name" buttom */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddFile : MonoBehaviour
{
	int count = 1;  // counts the number of specified GameObject in the scene

	public void TaskOnClickAddButton()
	{
		Instantiate (GameObject.Find (this.GetComponentInChildren<Text> ().text), Camera.main.ViewportToWorldPoint (new Vector3 (0.5f, 0.5f, 50.0f)), Quaternion.identity);  // Instantiates (adds) the GameObject which corresponds to that on the "name" button
		count++; // incrementing the number of objects
		this.gameObject.transform.Find ("Button_total").gameObject.GetComponentInChildren<Text> ().text = count.ToString (); // typecasts the count into string and then displays it
	}
}


