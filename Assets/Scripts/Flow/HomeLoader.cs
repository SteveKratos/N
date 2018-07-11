using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeLoader : MonoBehaviour
{


	void Start ()
	{
		
	}


	void Update ()
	{
		
	}

	public void LoadTrachTie ()
	{
		SceneManager.LoadSceneAsync ("TrachTie");
	}
}
