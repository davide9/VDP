﻿using UnityEngine;
using System.Collections;

public class missile : MonoBehaviour {

	private float speed = 2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = transform.position + transform.up * speed * Time.deltaTime;
	}
}
