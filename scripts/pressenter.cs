﻿using UnityEngine;
using System.Collections;

public class pressenter : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	if (Input.GetKeyDown (KeyCode.KeypadEnter)) {
			Application.LoadLevel ("cmdgame");
		}
	}
}
