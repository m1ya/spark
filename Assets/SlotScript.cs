using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotScript : MonoBehaviour {

	public float speed = 0.1f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (GameManager.stopFlag)
			return;
		transform.position += Vector3.down * speed;
		if (transform.position.y <= -17f) {
			transform.position = new Vector3(transform.position.x, 16.9f, transform.position.z);
		}
	}
}
