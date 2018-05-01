using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretControl : MonoBehaviour {

	public GameObject Bullet;

	float RotateSpeed = 10f;
	float BulletInterval = 3f;

	// Use this for initialization
	void Start () {
		Invoke ("CreateBullet", 0.1f);
	}
	
	// Update is called once per frame
	void Update () {
		float rotationAmount;
		rotationAmount = -RotateSpeed * Time.deltaTime;
		transform.Rotate (Vector3.forward, rotationAmount);
	}

	void CreateBullet(){
		Instantiate (Bullet, transform.position+transform.up*2, Quaternion.identity);
		Invoke ("CreateBullet", BulletInterval);
	}
}
