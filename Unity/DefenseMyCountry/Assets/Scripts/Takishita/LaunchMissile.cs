using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchMissile : MonoBehaviour {

    public GameObject m_Missile;
    public GameObject m_nowMissile;
    public float thrust = 10000f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			m_nowMissile = Instantiate (m_Missile, transform.position, Quaternion.identity);
			m_nowMissile.transform.parent = null;
			m_nowMissile.GetComponent<Missile> ().FireDir = transform.forward;
			m_nowMissile.GetComponent<Missile> ().KindKind = Missile.Kind.Own;
			// タッチ開始
		} else if (Input.GetMouseButton (0)) {
			// タッチ移動
		} else if (Input.GetMouseButtonUp (0)) {
			// タッチ終了

			//m_nowMissile.GetComponent<Rigidbody>().AddForce(Vector3.forward * thrust);

		}
	}
}
