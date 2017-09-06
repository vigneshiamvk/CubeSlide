using UnityEngine.SceneManagement;
using UnityEngine;

public class Welcome : MonoBehaviour {

	public void StartPlay () {
		SceneManager.LoadScene ("CubeGame");
	}

	public void Quit () {

		Application.Quit ();
	}
		
}
