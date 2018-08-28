using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManage : MonoBehaviour
{

	void Start () 
	{
		SceneManager.LoadScene ("Menu", LoadSceneMode.Additive);	
	}
	
	void Update ()
	{
		
	}
}
