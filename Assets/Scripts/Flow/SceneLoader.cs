using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{

	public GameObject logoCanvas;
	public GameObject HospitalCam;
	public GameObject LoadingCam;

	public string firstSceneName;

	public float firstSceneFadeTime;

	public float defaultFadeTime;

	public GameObject HospitalBG;
	static bool firstScene = true;
	static private string nextScene;



	static public void LoadSceneViaLoadingScene (string scene)
	{
		nextScene = scene;
		firstScene = false;
		SceneManager.LoadScene ("UI");

	}

	public void Start ()
	{
		
	}

	public void HospitalClicked ()
	{
		HospitalCam.GetComponent<Animator> ().enabled = true;
	}

	public void WelcomeButtonClicked ()
	{
		StartCoroutine (LoadMainScene ());
		HospitalBG.SetActive (false);
		HospitalCam.SetActive (false);
		LoadingCam.SetActive (true);
		logoCanvas.SetActive (true);

	}

	IEnumerator LoadMainScene ()
	{
		float fadeTime;

		if (firstScene) {
			nextScene = firstSceneName;
			fadeTime = firstSceneFadeTime;
			OVRManager.display.RecenterPose ();
		} else {
			fadeTime = defaultFadeTime;
		}


		Application.backgroundLoadingPriority = ThreadPriority.Low;
		AsyncOperation async = SceneManager.LoadSceneAsync (nextScene);
		async.allowSceneActivation = false;

		while (!async.isDone) {
			float loadProgress = async.progress;

			if (loadProgress >= 0.9f) {

				break;
			}

			yield return null;
		}

		float t = Time.time;
		SpriteRenderer sr = logoCanvas.GetComponentInChildren<SpriteRenderer> ();
		while (Time.time < t + fadeTime) {
			float i = 1 - (Time.time - t) / fadeTime;
			sr.color = new Color (i, i, i);
			yield return null;
		}

		yield return null;
		async.allowSceneActivation = true;

		yield return async;
		Debug.Log ("Loading complete");
	}
}