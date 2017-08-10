using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCollider : MonoBehaviour {

	private LevelManager levelManager;
	private BrickController brick;

	void OnCollisionEnter2D(Collision2D collider){
		print ("Collided");
	}

	void OnTriggerEnter2D(Collider2D trigger) {
		print ("Trigger");
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
		BrickController.haveLost = true;
		levelManager.LoadLevel ("Lose");
	}
}
