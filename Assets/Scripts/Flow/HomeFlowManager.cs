using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;




public class HomeFlowManager : MonoBehaviour
{
	public GameObject TrachButton;
	public Animator LiftAnimator1, LiftAnimator2, LiftCAmAnim;

	void Start ()
	{
		
	}


	void Update ()
	{
		
	}

	public void TrachButtonClicked ()
	{
		LiftAnimator1.enabled = true;
		LiftAnimator2.enabled = true;
		LiftCAmAnim.enabled = true;
		//SceneManager.LoadSceneAsync ("TrachTie");
	}
}
