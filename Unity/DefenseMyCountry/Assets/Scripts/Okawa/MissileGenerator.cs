using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileGenerator : MonoBehaviour
{
	[SerializeField]
	GameObject missile;

	[SerializeField]
	float fireInterval = 1.0f;

	// Use this for initialization
	void Start () 
	{
		StartCoroutine (GenerateMissileCoroutine ());
	}

	IEnumerator GenerateMissileCoroutine()
	{
		while (true)
		{
			GameObject obj = Instantiate (missile, gameObject.transform);

			yield return new WaitForSeconds (fireInterval);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
