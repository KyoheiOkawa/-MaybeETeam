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

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                m_nowMissile = Instantiate(m_Missile, Vector3.zero, Quaternion.identity);
                m_nowMissile.transform.parent = null;
                // タッチ開始
            }
            else if (touch.phase == TouchPhase.Moved)
            {
                // タッチ移動
            }
            else if (touch.phase == TouchPhase.Ended)
            {
                // タッチ終了

                m_nowMissile.GetComponent<Rigidbody>().AddForce(transform.forward * thrust);

            }
        }
        else
        {


            if (Input.GetMouseButtonDown(0))
            {
                //m_nowMissile = Instantiate(m_Missile, this.gameObject.transform);
                m_nowMissile = Instantiate(m_Missile, Vector3.zero, Quaternion.identity);
                // タッチ開始
            }
            else if (Input.GetMouseButton(0))
            {
                // タッチ移動
            }
            else if (Input.GetMouseButtonUp(0))
            {
                // タッチ終了

                m_nowMissile.GetComponent<Rigidbody>().AddForce(Vector3.forward * thrust);

            }
        }
		
	}
}
