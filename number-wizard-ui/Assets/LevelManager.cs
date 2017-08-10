using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	/* For the Start button. */
	public void LoadLevel(string name) {
		Application.LoadLevel (name);
	}

	/* For the quit button. */
	public void QuitRequest() {
		Debug.Log ("Quit requested");
		//Application.Quit;
	}
}
