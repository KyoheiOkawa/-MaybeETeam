﻿using System.Collections;
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
			transform.LookAt (transform.position + fireDir);
		}
	}

	[SerializeField]
	float moveSpeed = 1.0f;

	public enum Kind
	{
		Enemy,
		Own
	}

	public Kind kind = Kind.Enemy;

	public Kind KindKind {
		get {
			return kind;
		}
		set {
			kind = value;
		}
	}

	Rigidbody rig;

	[SerializeField]
	float lifeTime = 5.0f;

	// Use this for initialization
	void Start () 
	{
		Debug.Log (transform.position);

		rig = GetComponent<Rigidbody> ();
		rig.AddForce (fireDir * moveSpeed);

		Destroy (this.gameObject, lifeTime);
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.CompareTag ("Missile")) {

			var missile = col.gameObject.GetComponent<Missile> ();

			if (kind == Kind.Own && missile.KindKind == Kind.Enemy) {
				Destroy (col.gameObject);
				Destroy (this.gameObject);

				GameObject.FindObjectOfType<GameLogic> ().addScore ();

				var effect = Instantiate (Resources.Load ("Explosion"), transform.position, Quaternion.identity);
				Destroy (effect, 5.0f);
			}
		}
	}
}
