using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickController : MonoBehaviour {
	public GameObject smoke;

	private int hit;
	public static int brickCount = 0;

	private LevelManager levelManager;
	public Sprite[] hitSprites;

	public static bool haveLost = false;

	private BallController ball;

	// Use this for initialization
	void Start () {
		hit = 0;
		if (haveLost) {
			brickCount = 0;
			BrickController.haveLost = false;
		}
		print (haveLost);
		if (gameObject.CompareTag("Breakable")) {
			brickCount++;
		}
		print (brickCount.ToString ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D collider){
		hit++;
		int maxHits = hitSprites.Length + 1;
		if (hit >= maxHits) {
			if (gameObject.CompareTag ("Breakable")) {
				brickCount--;
				puffSmoke();
				print (brickCount.ToString());
				if (brickCount == 0) {
					levelManager = GameObject.FindObjectOfType<LevelManager> ();
					levelManager.LoadNextLevel ();
				}
			}
		} else {
			int spriteIndex = hit - 1;
			if (hitSprites [spriteIndex]) {
				this.GetComponent<SpriteRenderer> ().sprite = hitSprites [spriteIndex];
			}
		}
	}

	void puffSmoke() {
		GameObject smokePuff = Instantiate (smoke, gameObject.transform.position, Quaternion.identity);
		smokePuff.GetComponent<ParticleSystem>().startColor = gameObject.GetComponent<SpriteRenderer>().color;
		Destroy (gameObject);
	}
}
