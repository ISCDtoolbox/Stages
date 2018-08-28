using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation_joint90 : MonoBehaviour 
{
	private int i;
	private Vector3 pos0, pos1, pos2, pos3;

	void Start()
	{
		i = 0;	
		pos0 = new Vector3 (-90, 90, 0);
		pos1 = new Vector3 (-270, 0, 90);
		pos2 = new Vector3 (-180, 0, 90);
		pos3 = new Vector3 (-180, 180, -90);
	}


	
	void OnMouseOver()
	{
		if (Input.GetMouseButtonDown (1)) 
		{
			i++;
//			Debug.Log ("Value of right click i: " + i);

			if (i == 1) 
			{
				this.gameObject.transform.Rotate(pos1);
			}
			if (i == 2) 
			{
				this.gameObject.transform.Rotate(pos2);
			}
			if (i == 3) 
			{
				this.gameObject.transform.Rotate(pos3);
			}
			if (i == 4) 
			{
				this.gameObject.transform.Rotate(pos0);
				i = 0;
			}				

		}

		this.gameObject.transform.Rotate (0, Input.GetAxis ("Mouse ScrollWheel")*900, 0);

	}

}
