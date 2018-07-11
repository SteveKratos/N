using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class ProcedureFlowManager : MonoBehaviour
{
	public GameObject HomeButton;
	public GameObject EquipmentButton;
	public GameObject ExitButton;
	public GameObject SwapCam;
	public GameObject FirstCam;
	public GameObject SecondCam;
	public Transform TrackRemote1, TrackRemote2;

	void Start ()
	{
		
	}


	void Update ()
	{
		
	}

	public void HomeButtonClicked ()
	{
		SceneManager.LoadSceneAsync ("TrachTie");
	}

	public void EquipmentButtonClicked ()
	{
		SceneManager.LoadSceneAsync ("Equipment");
	}

	public void ExitButtonClicked ()
	{
		SceneManager.LoadSceneAsync ("Home");
	}

	public void SwapCamClicked ()
	{
		if (FirstCam.activeSelf) {
			SecondCam.SetActive (true);
			FirstCam.SetActive (false);
			OVRGazePointer.instance.rayTransform = TrackRemote2;
		} else if (SecondCam.activeSelf) {
			FirstCam.SetActive (true);
			SecondCam.SetActive (false);
			OVRGazePointer.instance.rayTransform = TrackRemote1;
		}
	}
}
