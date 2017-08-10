using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {
	private PaddleController paddle;
	private Vector3 paddleToBallVector;
	private Rigidbody2D rb;
	private bool hasStarted = false;
	// Use this for initialization
	void Start () {
		paddle = GameObject.FindObjectOfType<PaddleController> ();
		paddleToBallVector = this.transform.position - paddle.transform.position;
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (!hasStarted) {
			this.transform.position = paddle.transform.position + paddleToBallVector;
			if (Input.GetMouseButtonDown (0) || Input.GetMouseButtonDown (1)) {
				print ("Mouse was clicked");
				rb.velocity = new Vector2 (2.0f, 10.0f);
				hasStarted = true;
			}
		}
	}
	void OnCollisionEnter2D(Collision2D collider){
		Vector2 randomness = new Vector2 (Random.Range (0.0f, 0.2f), Random.Range (0.0f, 0.2f));

		if (hasStarted) {
			gameObject.GetComponent<AudioSource>().Play ();
			rb.velocity += randomness;
		}
	}
}
