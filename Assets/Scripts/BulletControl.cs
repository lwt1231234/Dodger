using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour {

	float AliveTime = 10f;

	// Use this for initialization
	void Start () {
		GameObject Turrent = GameObject.Find ("Turret");

		this.gameObject.GetComponent<Rigidbody2D>().velocity=Turrent.transform.up;
		this.gameObject.GetComponent<Rigidbody2D>().AddForce (Turrent.transform.up * 1f,ForceMode2D.Force);

		Invoke ("End", AliveTime);
	}
	
	// Update is called once per frame
	void Update () {
		//print (this.gameObject.GetComponent<Rigidbody2D> ().velocity);
	}

	void End(){
		Destroy (gameObject);
	}
}
