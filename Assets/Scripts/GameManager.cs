using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public bool gameOver = false;
	public float restartDelay = 3f;

	public GameObject GamoverUI;

	public GameObject LevelWinUI;

	public void StartPlay () {
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
	}

	public void Quit () {

		Application.Quit ();
	}

	public void OnWin () {

		LevelWinUI.SetActive (true);
	}

	public void EndGame()

	{
		if (gameOver == false) {
			gameOver = true;
			Debug.Log ("Game Over");
			GamoverUI.SetActive (true);
			Invoke ("Restart", restartDelay);
		}
	}

	void Restart()
	{
		SceneManager.LoadScene ("Welcome");
	}
}
