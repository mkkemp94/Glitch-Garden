﻿using UnityEngine;
using System.Collections;

public class SplashScript : MonoBehaviour {

	float timeLeft = 5f;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		timeLeft -= Time.deltaTime;
		if (timeLeft <= 0) {
			Application.LoadLevel("01 Start");
		}
	}
}
