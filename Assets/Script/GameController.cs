﻿using System.Collections;
using UnityEngine;

public class GameController : MonoBehaviour {
	public UnityEngine.UI.Text scoreLabel;

	public void Update () {
		int count = GameObject.FindGameObjectsWithTag("item").Length;
		scoreLabel.text= count.ToString();
	}
}
