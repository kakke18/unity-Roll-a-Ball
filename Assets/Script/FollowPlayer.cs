using System.Collections;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {
	public Transform target; //Reference to target
	private Vector3 offset; //Relative coordinate

	void Start() {
		//calculate relative coordinate
		offset = GetComponent<Transform>().position - target.position;
	}

	void Update () {
		//Assign coordinate
		GetComponent<Transform>().position = target.position + offset;
	}
}
