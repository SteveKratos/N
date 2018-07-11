using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
using UnityEngine.UI;

public class ProcedureManager : MonoBehaviour
{
	public AudioSource ProcedureAudioSource;
	public List<AudioClip> ProcedureAudioClips;
	public Animator ProcedureAnimator;
	public AnimatorClipInfo[] animClipInfo;
	public string animationName;
	public bool isMuted;
	public bool isPaused;
	public Text DebugText;

	void Start ()
	{
		
	}


	void Update ()
	{
		
	}

	public void ProcedureStepButtonClicked ()
	{
		switch (EventSystem.current.currentSelectedGameObject.name) {
		case "Procedure1":
			

			ProcedureAnimator.SetInteger ("Procedure", 1);
			ProcedureAudioSource.PlayOneShot (ProcedureAudioClips [0]);
			break;
		case "Procedure2":

			ProcedureAnimator.SetInteger ("Procedure", 2);
			ProcedureAudioSource.PlayOneShot (ProcedureAudioClips [1]);
			break;
		case "Procedure3":
			ProcedureAnimator.SetInteger ("Procedure", 3);
		
			ProcedureAudioSource.PlayOneShot (ProcedureAudioClips [2]);
			break;
		case "Procedure4":
			ProcedureAnimator.SetInteger ("Procedure", 4);

			ProcedureAudioSource.PlayOneShot (ProcedureAudioClips [3]);
			break;
		case "Procedure5":
			ProcedureAnimator.SetInteger ("Procedure", 5);
			DebugText.text = "Procedure5Clicked";
			ProcedureAudioSource.PlayOneShot (ProcedureAudioClips [4]);
			break;
		case "Procedure6":
			ProcedureAnimator.SetInteger ("Procedure", 6);
		
			ProcedureAudioSource.PlayOneShot (ProcedureAudioClips [5]);
			break;
		case "Procedure7":
			ProcedureAnimator.SetInteger ("Procedure", 7);
			ProcedureAudioSource.PlayOneShot (ProcedureAudioClips [6]);
			break;
		case "Procedure8":
			ProcedureAnimator.SetInteger ("Procedure", 8);
			ProcedureAudioSource.PlayOneShot (ProcedureAudioClips [7]);
			break;
		case "Procedure9":
			ProcedureAnimator.SetInteger ("Procedure", 9);
			ProcedureAudioSource.PlayOneShot (ProcedureAudioClips [8]);
			break;
		case "Procedure10":
			ProcedureAnimator.SetInteger ("Procedure", 10);
			ProcedureAudioSource.PlayOneShot (ProcedureAudioClips [9]);
			break;
		case "Procedure11":
			ProcedureAnimator.SetInteger ("Procedure", 11);
			ProcedureAudioSource.PlayOneShot (ProcedureAudioClips [10]);
			break;
		case "Procedure12":
			ProcedureAnimator.SetInteger ("Procedure", 12);
			ProcedureAudioSource.PlayOneShot (ProcedureAudioClips [11]);
			break;
		case "Procedure13":
			ProcedureAnimator.SetInteger ("Procedure", 13);
			ProcedureAudioSource.PlayOneShot (ProcedureAudioClips [12]);
			break;
		case "Procedure14":
			ProcedureAnimator.SetInteger ("Procedure", 14);
			ProcedureAudioSource.PlayOneShot (ProcedureAudioClips [13]);
			break;
		case "Procedure15":
			ProcedureAnimator.SetInteger ("Procedure", 15);
			ProcedureAudioSource.PlayOneShot (ProcedureAudioClips [14]);
			break;
		case "Procedure16":

			ProcedureAnimator.SetInteger ("Procedure", 16);
			ProcedureAudioSource.PlayOneShot (ProcedureAudioClips [15]);
			break;
		case "Procedure17":
	
			ProcedureAnimator.SetInteger ("Procedure", 17);
			ProcedureAudioSource.PlayOneShot (ProcedureAudioClips [16]);
			break;
		case "Procedure18":

			ProcedureAnimator.SetInteger ("Procedure", 18);
			ProcedureAudioSource.PlayOneShot (ProcedureAudioClips [17]);
			break;
		case "Procedure19":
	
			ProcedureAnimator.SetInteger ("Procedure", 19);
			ProcedureAudioSource.PlayOneShot (ProcedureAudioClips [18]);
			break;
		case "Procedure20":

			ProcedureAnimator.SetInteger ("Procedure", 20);
			ProcedureAudioSource.PlayOneShot (ProcedureAudioClips [19]);
			break;
		case "Procedure21":

			ProcedureAnimator.SetInteger ("Procedure", 21);
			ProcedureAudioSource.PlayOneShot (ProcedureAudioClips [20]);
			break;
		default:
			break;
		}

	}

	public void ProcedureSwitchButtonClicked ()
	{
		animClipInfo = ProcedureAnimator.GetCurrentAnimatorClipInfo (0);
		switch (animClipInfo [0].clip.name) {
		case  "Procedure1":
			if (EventSystem.current.currentSelectedGameObject.name == "Next") {
				//ProcedureAnimator.SetInteger ("Procedure", 2);
				ProcedureAnimator.Play ("Procedure2");
			}

			if (EventSystem.current.currentSelectedGameObject.name == "Previous") {
				ProcedureAnimator.Play ("Procedure1");
			}
			break;
		case  "Procedure2":
			if (EventSystem.current.currentSelectedGameObject.name == "Next") {
				ProcedureAnimator.Play ("Procedure3");
			}

			if (EventSystem.current.currentSelectedGameObject.name == "Previous") {
				ProcedureAnimator.Play ("Procedure1");
			}
			break;
		case "Procedure3":
			if (EventSystem.current.currentSelectedGameObject.name == "Next") {
				ProcedureAnimator.Play ("Procedure4");
			}

			if (EventSystem.current.currentSelectedGameObject.name == "Previous") {
				ProcedureAnimator.Play ("Procedure2");
			}
			break;
		case "Procedure4":
			if (EventSystem.current.currentSelectedGameObject.name == "Next") {
				ProcedureAnimator.Play ("Procedure5");
			}

			if (EventSystem.current.currentSelectedGameObject.name == "Previous") {
				ProcedureAnimator.Play ("Procedure3");
			}
			break;
		case "Procedure5":
			if (EventSystem.current.currentSelectedGameObject.name == "Next") {
				ProcedureAnimator.Play ("Procedure6");
			}

			if (EventSystem.current.currentSelectedGameObject.name == "Previous") {
				ProcedureAnimator.Play ("Procedure4");
			}
			break;
		case "Procedure6":
			if (EventSystem.current.currentSelectedGameObject.name == "Next") {
				ProcedureAnimator.Play ("Procedure7");
			}

			if (EventSystem.current.currentSelectedGameObject.name == "Previous") {
				ProcedureAnimator.Play ("Procedure5");
			}
			break;
		case "Procedure7":
			if (EventSystem.current.currentSelectedGameObject.name == "Next") {
				ProcedureAnimator.Play ("Procedure8");
			}

			if (EventSystem.current.currentSelectedGameObject.name == "Previous") {
				ProcedureAnimator.Play ("Procedure6");
			}
			break;
		case "Procedure8":
			if (EventSystem.current.currentSelectedGameObject.name == "Next") {
				ProcedureAnimator.Play ("Procedure9");
			}

			if (EventSystem.current.currentSelectedGameObject.name == "Previous") {
				ProcedureAnimator.Play ("Procedure7");
			}
			break;
		case "Procedure9":
			if (EventSystem.current.currentSelectedGameObject.name == "Next") {
				ProcedureAnimator.Play ("Procedure10");
			}

			if (EventSystem.current.currentSelectedGameObject.name == "Previous") {
				ProcedureAnimator.Play ("Procedure8");
			}
			break;
		case "Procedure10":
			if (EventSystem.current.currentSelectedGameObject.name == "Next") {
				ProcedureAnimator.Play ("Procedure11");
			}

			if (EventSystem.current.currentSelectedGameObject.name == "Previous") {
				ProcedureAnimator.Play ("Procedure9");
			}
			break;
		case "Procedure11":
			if (EventSystem.current.currentSelectedGameObject.name == "Next") {
				ProcedureAnimator.Play ("Procedure12");
			}

			if (EventSystem.current.currentSelectedGameObject.name == "Previous") {
				ProcedureAnimator.Play ("Procedure10");
			}
			break;
		case "Procedure12":
			if (EventSystem.current.currentSelectedGameObject.name == "Next") {
				ProcedureAnimator.Play ("Procedure13");
			}

			if (EventSystem.current.currentSelectedGameObject.name == "Previous") {
				ProcedureAnimator.Play ("Procedure11");
			}
			break;
		case "Procedure13":
			if (EventSystem.current.currentSelectedGameObject.name == "Next") {
				ProcedureAnimator.Play ("Procedure14");
			}

			if (EventSystem.current.currentSelectedGameObject.name == "Previous") {
				ProcedureAnimator.Play ("Procedure12");
			}
			break;
		case "Procedure14":
			if (EventSystem.current.currentSelectedGameObject.name == "Next") {
				ProcedureAnimator.Play ("Procedure15");
			}

			if (EventSystem.current.currentSelectedGameObject.name == "Previous") {
				ProcedureAnimator.Play ("Procedure13");
			}
			break;
		case "Procedure15":
			if (EventSystem.current.currentSelectedGameObject.name == "Next") {
				ProcedureAnimator.Play ("Procedure16");
			}

			if (EventSystem.current.currentSelectedGameObject.name == "Previous") {
				ProcedureAnimator.Play ("Procedure14");
			}
			break;
		case "Procedure16":
			if (EventSystem.current.currentSelectedGameObject.name == "Next") {
				ProcedureAnimator.Play ("Procedure17");
			}

			if (EventSystem.current.currentSelectedGameObject.name == "Previous") {
				ProcedureAnimator.Play ("Procedure15");
			}
			break;
		case "Procedure17":
			if (EventSystem.current.currentSelectedGameObject.name == "Next") {
				ProcedureAnimator.Play ("Procedure18");
			}

			if (EventSystem.current.currentSelectedGameObject.name == "Previous") {
				ProcedureAnimator.Play ("Procedure16");
			}
			break;
		case "Procedure18":
			if (EventSystem.current.currentSelectedGameObject.name == "Next") {
				ProcedureAnimator.Play ("Procedure19");
			}

			if (EventSystem.current.currentSelectedGameObject.name == "Previous") {
				ProcedureAnimator.Play ("Procedure17");
			}
			break;
		case "Procedure19":
			if (EventSystem.current.currentSelectedGameObject.name == "Next") {
				ProcedureAnimator.Play ("Procedure20");
			}

			if (EventSystem.current.currentSelectedGameObject.name == "Previous") {
				ProcedureAnimator.Play ("Procedure18");
			}
			break;
		case "Procedure20":
			if (EventSystem.current.currentSelectedGameObject.name == "Next") {
				ProcedureAnimator.Play ("Procedure21");
			}

			if (EventSystem.current.currentSelectedGameObject.name == "Previous") {
				ProcedureAnimator.Play ("Procedure19");
			}
			break;
		case "Procedure21":
			if (EventSystem.current.currentSelectedGameObject.name == "Next") {
				ProcedureAnimator.Play ("Procedure21");
			}

			if (EventSystem.current.currentSelectedGameObject.name == "Previous") {
				ProcedureAnimator.Play ("Procedure20");
			}
			break;
		default:
			break;


		}
	}

	public void PauseButtonClicked ()
	{
		ProcedureAnimator.speed = 0;
		ProcedureAudioSource.Pause ();
		isPaused = true;
	}

	public void PlayButtonClicked ()
	{
		ProcedureAnimator.speed = 1;
		ProcedureAudioSource.Play ();
		isPaused = false;
	}

	public void MuteButtonClicked ()
	{
		ProcedureAudioSource.volume = 0;
		isMuted = true;
	}

	public void UnMuteButtonClicked ()
	{
		ProcedureAudioSource.volume = 1;
		isMuted = false;
	}
}
