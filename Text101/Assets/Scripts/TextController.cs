using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text message;
	private string newmessage;

	private enum States {cell, mirror, cell_mirror, sheets_0, lock_0, sheets_1, lock_1, freedom};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.cell;

	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.cell) {
			state_cell ();
		} else if (myState == States.sheets_0) {
			state_sheets_0 ();
		} else if (myState == States.lock_0) {
			state_lock_0 ();
		} else if (myState == States.mirror) {
			state_mirror ();
		} else if (myState == States.cell_mirror) {
			state_cell_mirror ();
		} else if (myState == States.sheets_1) {
			state_sheets_1 ();
		} else if (myState == States.lock_1) {
			state_lock_1 ();
		} else if (myState == States.freedom) {
			state_freedom ();
		}
	}
	void state_cell() {
		newmessage = "You are in a prison cell, and you want to escape. There are some dirty sheets " +
						"on the bed, a mirror on the wall, and the door is locked from the outside.\n\n" +
						"Press S to view Sheets, M to view Mirrow, L to view Lock.";
		changeMessage (newmessage);
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.sheets_0;
		} else if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.mirror;
		} else if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.lock_0;
		}
	}
	void state_sheets_0() {
		newmessage = "Oh my, look at how dirty these sheets are, I can't believe they make you sleep in these. " +
					"Best get away from these until someone washes them.\n\n Press R to return to your cell.";
		changeMessage (newmessage);
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		}
	}
	void state_mirror() {
		newmessage = "Mirror mirror on the wall please show me how to get out of here. Oh this here could " +
			"be useful.\n\n Press T to take the mirror.";
		changeMessage (newmessage);
		if (Input.GetKeyDown (KeyCode.T)) {
			myState = States.cell_mirror;
		}
	}
	void state_lock_0() {
		newmessage = "What do you know the prison actually has locked doors. I should step away from this " + 
			         "before they think I am trying to escape.\n\n Press R to return to your cell.";
		changeMessage (newmessage);
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		}
	}
	void state_cell_mirror() {
		newmessage = "You are in a prison cell with a mirror, and you want to escape. There are some dirty sheets " +
			"and the door is locked from the outside.\n\n" +
			"Press S to view Sheets, L to view Lock.";
		changeMessage (newmessage);
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.sheets_1;
		} else if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.lock_1;
		}
	}

	void state_sheets_1() {
		newmessage = "What a surprise these are stil dirty." +
			"Wow they stink, I do not want to stand here any longer.\n\n Press R to return to your cell.";
		changeMessage (newmessage);
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell_mirror;
		}
	}
		
	void state_lock_1() {
		newmessage = "What do you know this here from the mirror might fit.\n" +
		"*Inserts and twists door knob just a bit*.\nIt's open! Sayonara suckers, I'm out this place!\n\n " +
		"Press O to open and escape or press R to return to your cell.";
		changeMessage (newmessage);
		if (Input.GetKeyDown (KeyCode.O)) {
			myState = States.freedom;
		}
		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell_mirror;
		}
	}

	void state_freedom() {
		newmessage = "Congratulations you are free, you may now do whatever it is your heart desires\n\n"
			+ "Press P to play again.";
		changeMessage (newmessage);
		if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.cell;
		}
	}

	void changeMessage(string newm) {
		message.text = newm;
	}
}
