using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour {
	// Use this for initialization
	public bool autoPlay = false;
	private BallController ball;
	void Start () {
		ball = GameObject.FindObjectOfType<BallController> ();
	}
	
	// Update is called once per frame
	void Update() {
		if (!autoPlay) {
			MoveWithMouse ();
		} else {
			MoveWithBall ();
		}
	}

	void MoveWithMouse() {
		Vector3 paddlePos = new Vector3 (8.0f, this.transform.position.y, 0.0f);
		float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16;
		paddlePos.x = Mathf.Clamp(mousePosInBlocks, 0.5f, 15.5f);
		this.transform.position = paddlePos;
	}

	void MoveWithBall() {
		Vector3 paddlePos = new Vector3 (8.0f, this.transform.position.y, 0.0f);
		Vector3 ballPos = ball.transform.position;
		paddlePos.x = Mathf.Clamp(ballPos.x, 0.5f, 15.5f);
		this.transform.position = paddlePos;
	}
}
        /* another way to constraint the x position of the paddle, involves making a new vector again 
		which is not good !

		paddlePos.x = mousePosInBlocks;
		this.transform.position = new Vector3(Mathf.Clamp(paddlePos.x, 0.5f, 15.5f), paddlePos.y, paddlePos.z); */
