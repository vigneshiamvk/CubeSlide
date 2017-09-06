using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public Rigidbody rb;

	public float forwardForce = 2000f;
	public float sideForce = 500f;


	void FixedUpdate () 
	{
		//push forward
		rb.AddForce (0, 0, forwardForce * Time.deltaTime);

		if(Input.GetKey("d")) 
		{
			//move sideways
			rb.AddForce (sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);		
		}

		if(Input.GetKey("a")) 
		{
			//move sideways
			rb.AddForce (-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);		
		}

		if (rb.position.y < -1f) {
			FindObjectOfType<GameManager> ().EndGame ();
		}
	}
}
