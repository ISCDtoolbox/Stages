using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxExit_JointColl : MonoBehaviour 
{
	private Vector3 exitPivotPos, exitObjScale;
	private Quaternion exitPivotRot;

	void Start () 
	{
	}
	
	void Update ()
	{

		
	}

	void OnTriggerStay (Collider other)
	{
		if (this.gameObject.tag == "collider_bottom") // to avoid using two different scripts for colliderBottom and colliderUp _ can also be removed if not needed
		{
			if (other.gameObject.tag == "joint_S") // to identify the incoming object which makes collision with this cube
			{
				exitPivotPos = this.gameObject.transform.position;
				other.gameObject.transform.position = exitPivotPos;

//				exitPivotRot = this.gameObject.transform.rotation;
//				other.gameObject.transform.rotation = exitPivotRot;

				other.gameObject.transform.localScale = new Vector3(this.gameObject.transform.parent.localScale.x, this.gameObject.transform.parent.localScale.y, other.gameObject.transform.localScale.z);

			}

			if (other.gameObject.tag == "pipe") 
			{
				exitPivotPos = this.gameObject.transform.position;
				other.gameObject.transform.position = exitPivotPos;

				exitPivotRot = this.gameObject.transform.rotation;
				other.gameObject.transform.rotation = exitPivotRot;

				other.gameObject.transform.localScale = new Vector3(this.gameObject.transform.parent.localScale.x, this.gameObject.transform.parent.localScale.y, other.gameObject.transform.localScale.z);

			} 
			if (other.gameObject.tag == "joint_135")
			{
				exitPivotPos = this.gameObject.transform.position;
				other.gameObject.transform.position = exitPivotPos;

				exitPivotRot = this.gameObject.transform.rotation;
				other.gameObject.transform.rotation = exitPivotRot;

				other.gameObject.transform.localScale = new Vector3(this.gameObject.transform.parent.localScale.x, this.gameObject.transform.parent.localScale.y, other.gameObject.transform.localScale.z);

			}
			
			if (other.gameObject.tag == "joint_90") 
			{
				exitPivotPos = this.gameObject.transform.position;
				other.gameObject.transform.position = exitPivotPos;

//				exitPivotRot = this.gameObject.transform.rotation;
//				other.gameObject.transform.rotation = exitPivotRot;

				other.gameObject.transform.localScale = new Vector3(this.gameObject.transform.parent.localScale.x, this.gameObject.transform.parent.localScale.y, other.gameObject.transform.localScale.z);

			}

		} // if (colliderBottom)

		else if (this.gameObject.tag == "collider_up")
		{
			if (other.gameObject.tag == "joint_S") 
			{
				exitPivotPos = this.gameObject.transform.position;
				Debug.Log ("transform position: " +exitPivotPos);


			}
		}


	} // OnTriggerStay

}
