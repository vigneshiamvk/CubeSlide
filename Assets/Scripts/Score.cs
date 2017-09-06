using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Transform player;
	public Text scoreText;

	void Update()
	{	
		scoreText.text = "Score: " + player.position.z.ToString("0");
	}
}
