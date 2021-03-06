﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	//control speed
	public float speed = 10;

	void FixedUpdate() {
		//input x, z
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");

		//get rigidbody component
		Rigidbody rigidbody = GetComponent<Rigidbody>();

		//add force of x, z
		rigidbody.AddForce(x * speed, 0, z * speed);
	}
}
