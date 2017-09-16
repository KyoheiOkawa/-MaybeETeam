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
			GameObject obj = Instantiate (missile, transform.position,Quaternion.identity);
			float random = Random.Range (0.2f, 0.6f);

			int witch = 1;
			if ((int)Random.Range (0, 100) >= 50)
				witch *= -1;

			obj.GetComponent<Missile> ().FireDir = new Vector3(0,(1.0f-random),random);

			yield return new WaitForSeconds (fireInterval);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
