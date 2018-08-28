/* This script loads multiple scene */

using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoading : MonoBehaviour
{
	void Start ()
	{
		SceneManager.LoadScene ("Catalogue", LoadSceneMode.Additive); // loads the scene "Catalogue" in additive(one scene over another) mode
	}

}
