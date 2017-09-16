using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour {
	[SerializeField]
	Vector3 moveDir = Vector3.up;

	[SerializeField]
	float moveSpeed = 1.0f;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.Translate (moveDir * moveSpeed * Time.deltaTime);	
	}
}
