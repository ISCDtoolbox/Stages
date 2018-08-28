using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color_green : MonoBehaviour 
{
	private Color oldColor;
	private bool timeUp;

	void Start ()
	{
		timeUp = false;
	}

	void Update()
	{

	}
	void OnTriggerEnter(Collider other)
	{
		if (this.gameObject.tag == "collider_bottom")
		{
			if (other.gameObject.tag == "joint_S" || other.gameObject.tag == "pipe" || other.gameObject.tag == "joint_135" || other.gameObject.tag == "joint_90") 
			{
				ChangeColorFor2Sec (other.gameObject.GetComponentInParent<Renderer> ());
			}

			if (timeUp) 
			{
				Debug.Log ("timeup True block");
				other.gameObject.GetComponentInParent<Renderer> ().material.color = oldColor;
				timeUp = false;
			}

		}

	} //OnTriggerEnter

	void OnTriggerStay(Collider other)
	{
		if (this.gameObject.tag == "collider_bottom")
		{
//			if (other.gameObject.tag == "joint_S" || other.gameObject.tag == "pipe" || other.gameObject.tag == "joint_135" || other.gameObject.tag == "joint_90") 
//			{
//				ChangeColorFor2Sec (other.gameObject.GetComponentInParent<Renderer> ());
//			}

			if (timeUp) 
			{
				Debug.Log ("timeup True block");
				other.gameObject.GetComponentInParent<Renderer> ().material.color = oldColor;
				timeUp = false;
			}

		}

	}//OnTriggerStay

	void ChangeColorFor2Sec(Renderer rend)
	{
		oldColor = rend.material.color;
		rend.material.color = Color.green;
		StartCoroutine ("HoldOnFor");



	}
		
	IEnumerator HoldOnFor ()
	{
		yield return new WaitForSeconds (2);
		timeUp = true;
	}
}
