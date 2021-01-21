﻿using UnityEngine;
using System.Collections;

/**
 * Prosty skrypt odpowiedzialny za ukrycie celownika.
 * 
 *
 */
public class HideCursor : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp (KeyCode.Escape)) {
			if(Cursor.visible){
				Cursor.visible = false;
			} else {
				Cursor.visible = true;
			}
			if(Cursor.lockState == CursorLockMode.Locked){
				Cursor.lockState = CursorLockMode.Confined;
			} else {
				Cursor.lockState = CursorLockMode.Locked;
			}
			//Cursor.lockState = CursorLockMode.Locked;
		}
	}
}
