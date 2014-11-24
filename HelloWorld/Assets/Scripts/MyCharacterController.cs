using UnityEngine;
using System.Collections;

public class MyCharacterController : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 direction = Vector3.zero;
		// Is Up pressed?
		if (Input.GetKey (KeyCode.UpArrow) == true) {
			// Move Character up by some amount
			direction.y += 0.1f;
		}
		// Is Left Pressed?
		if (Input.GetKey (KeyCode.LeftArrow) == true) {
			// Move Character up by some amount
			direction.x -= 0.1f;
		}
		// Is Right Pressed?
		if (Input.GetKey (KeyCode.RightArrow) == true) {
			// Move Character up by some amount
			direction.x += 0.1f;
		}
		// Is Down Pressed?
		if (Input.GetKey (KeyCode.DownArrow) == true) {
						// Move Character down by some amount
						direction.y -= 0.1f;
				}
		gameObject.transform.Translate (direction);
	}
}
