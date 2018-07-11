using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TrachTieFlowManager : MonoBehaviour
{
	public GameObject TrachTieButton;

	void Start ()
	{
		
	}


	void Update ()
	{
		
	}

	public void TrachTieButtonClicked ()
	{
		SceneManager.LoadSceneAsync ("Procedure");
	}
}
