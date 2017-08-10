using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	private int max;
	private int min;
	private int guess;
	public int maxTries = 10;

	public Text text;
	public Text tries;

	// Use this for initialization
	void Start () {
		StartGame ();
	}

	void StartGame() {
		max = 1000;
		min = 1;
		Next ();
		tries.text = "Number of AI tries remaining:\n" + maxTries;
	}
		
	public void GuessHigher(){
		min = guess;
		Next ();
	}

	public void GuessLower(){
		max = guess;
		Next ();
	}

//	public void GuessRight(){
//		Application.LoadLevel ("Lose");
//	}

	void Next() {
		guess = Random.Range (min, max+1);
		text.text = "My guess is\n" + guess.ToString ();
		maxTries -= 1;
		tries.text = "Number of AI tries remaining:\n" + maxTries;
		if (maxTries <= 0) {
			//jump to win screen
			Application.LoadLevel("Win");
		}
	}
}
