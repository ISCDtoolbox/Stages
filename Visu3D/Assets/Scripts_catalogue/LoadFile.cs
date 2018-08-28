/*
This scripts loads the .obj file into the scene
*/

using UnityEngine;
using UnityEditor;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

[RequireComponent(typeof(Collider))]  // Adds the collider component to the imported gameobject
[RequireComponent(typeof(Rigidbody))]  // Adds the rigidbody component to the imported gameobject

public class LoadFile : MonoBehaviour 
{
	string path = null;  
//	string path_mat = null;
	public Button nameButton;
	public GameObject nameContentPanel; 

	private GameObject loadedFile, childObj;
	private string fileName;
	private Button namBut;
	private List<string> listGoName;

	void Start()
	{
		listGoName = new List<string>();
		fileName = "";
	} 

	public void TaskOnClickFile()
	{
		path = EditorUtility.OpenFilePanel ("Choose your .obj file", "", "obj");	// Opens the dialog window to choose the .obj file
		loadedFile = OBJLoader.LoadOBJFile (path); // loaded object is stored in loadedfile
		loadedFile.transform.position = Camera.main.ViewportToWorldPoint (new Vector3 (0.5f, 0.5f, 50.0f)); // it is placed in center of the viewport

//		path_mat = EditorUtility.OpenFilePanel ("Choose the Material (.mtl) file", "", "mtl");
//		loadedFile.GetComponent<Renderer> ().material = fOBJLoader.LoadMTLFile (path_mat) as Material;

		childObj = loadedFile.gameObject.transform.GetChild (0).gameObject;  // retrives the childobject (the mesh object) from the parent(empty gameobject) object

		childObj.AddComponent<Rigidbody> ().isKinematic = true; // Rigidbody is added simulatneously kinematic is set true
		childObj.AddComponent<BoxCollider> ().isTrigger = true; // BoxCollider is added simulatneously trigger is set true

		if (!listGoName.Contains(loadedFile.name))  // checks and enters the loop if the list listGoName doesn't contains the loaded file
		{
			namBut = Instantiate (nameButton, nameContentPanel.transform);  // instantiates the nameButton with its corresponding transform
			fileName = loadedFile.name; // the loaded file name is stored in fileName variable
			namBut.GetComponentInChildren<Text> ().text = fileName; // this fileName is displayed in text filed of the namBut Button
			namBut.transform.Find ("Button_total").gameObject.GetComponentInChildren<Text> ().text = 1.ToString(); // the Button_total text field is set to 1 by default
			listGoName.Add(loadedFile.name); // the loadedfile name is added to the list listGoName 
			childObj.AddComponent<Manip_Imports> (); // Manip_Imports is added to the childObject
			childObj.AddComponent<TextureLoader> (); //TextureLoader script is added to the childObject ***but its not working***
		} 

		else if (listGoName.Contains(loadedFile.name)) // checks and enters the loop if the list listGoName contains the loaded file
		{
			Debug.Log("file already exists"); // displays the error 
			Destroy (loadedFile); // loaded file is destroyed
		}
	
	}
}
