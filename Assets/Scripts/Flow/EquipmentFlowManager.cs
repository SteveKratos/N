using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EquipmentFlowManager : MonoBehaviour
{

	// Use this for initialization.
	public GameObject HomeButton;
	public GameObject ExitButton;

	void Start ()
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	public void HomeButtonClicked ()
	{
		SceneManager.LoadSceneAsync ("Home");
	}

	public void ExitButtonClicked ()
	{
		SceneManager.LoadSceneAsync ("TrachTie");
	}
}
