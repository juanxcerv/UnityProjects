using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour {
	static MusicPlayer instance = null;
	void Awake() {
		if (MusicPlayer.instance != null) {
			Destroy (gameObject);
		} else {
			GameObject.DontDestroyOnLoad (gameObject);
			instance = this;
		}
	}
		
	// Update is called once per frame
	void Update () {
		
	}
}
//      static bool isplaying = false;
//		void Start() {
//			if (MusicPlayer.isplaying == false) {
	//			GameObject.DontDestroyOnLoad (gameObject);
	//		} else {
	//			Destroy (gameObject);
	//		}
	//		MusicPlayer.isplaying = true;
	//	}
