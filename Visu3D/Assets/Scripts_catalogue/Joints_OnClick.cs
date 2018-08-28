/* This script is insantiates the corresponding joints upon clicking it on the menu
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Joints_OnClick : MonoBehaviour 
{
	public GameObject ObjectPrefab;
	private Vector3 pos;

	void Start()
	{
		
	}

	public void TaskOnClick()
	{
		pos = Camera.main.ViewportToWorldPoint (new Vector3 (0.5f, 0.5f, 3.0f));  // pos retrives the center of the viewport
		Instantiate (ObjectPrefab, pos, ObjectPrefab.transform.rotation).AddComponent<Manip_Imports>(); // Insantiates the joint with its rotation and then adds the "Manip_Imports" scripts to it simulatneously
	}

}
