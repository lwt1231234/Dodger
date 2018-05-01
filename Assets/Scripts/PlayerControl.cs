using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	float playerSpeed = 1;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 moveDirection = Vector2.zero;

		if (Input.GetKey (KeyCode.LeftArrow)||Input.GetKey (KeyCode.A)) 
			moveDirection+= new Vector2(-1,0);
		if (Input.GetKey (KeyCode.RightArrow)||Input.GetKey (KeyCode.D)) 
			moveDirection+= new Vector2(1,0);
		if (Input.GetKey (KeyCode.UpArrow)||Input.GetKey (KeyCode.W)) 
			moveDirection+= new Vector2(0,1);
		if (Input.GetKey (KeyCode.DownArrow )||Input.GetKey (KeyCode.S)) 
			moveDirection+= new Vector2(0,-1);

		gameObject.transform.localPosition += (Vector3)moveDirection * Time.deltaTime * playerSpeed;
		this.gameObject.GetComponent<Rigidbody2D> ().velocity = Vector2.zero;

	}
}
