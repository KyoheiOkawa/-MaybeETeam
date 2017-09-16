using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Missile : MonoBehaviour {

	[SerializeField]
	Vector3 fireDir = Vector3.up;

	public Vector3 FireDir
	{
		set
		{
			fireDir = value;
		}
	}

	[SerializeField]
	float moveSpeed = 1.0f;

	Rigidbody rig;

	// Use this for initialization
	void Start () 
	{
		Debug.Log (transform.position);

		rig = GetComponent<Rigidbody> ();
		rig.AddForce (fireDir * moveSpeed);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
