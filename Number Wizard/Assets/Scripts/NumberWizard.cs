using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	private int max;
	private int min;
	private int guess;

	// Use this for initialization
	void Start () {
		StartMessage ();
	}

	void StartMessage() {
		max = 1000;
		min = 1;
		guess = 500;

		max += 1;

		print ("========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me what it is!");

		print (" The highest number you can pick is " + max.ToString ());
		print (" The lowest number you can pick is " + min.ToString ());

		print (" Is the number higher or lower than " + guess.ToString() + "?");
		print (" Up = higher, down = lower, return = equal");
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess;
			Next ();
		}
		else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess;
			Next ();
		}
		else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("You won!");
			StartMessage ();
		}
	}
	void Next() {
		guess = (max + min) / 2;
		print ("Is your number higher or lower than " + guess.ToString () + "?");
		print (" Up = higher, down = lower, return = equal");
	}
}
