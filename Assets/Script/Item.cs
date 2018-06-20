﻿using System.Collections;
using UnityEngine;

public class Item : MonoBehaviour {
	//Callback
	void OnTriggerEnter (Collider hit) {
		if (hit.CompareTag("Player")) {
			Destroy(gameObject);
		}
	}
}
