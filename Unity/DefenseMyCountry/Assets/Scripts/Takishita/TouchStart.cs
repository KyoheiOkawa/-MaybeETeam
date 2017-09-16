using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchStart : MonoBehaviour {

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
				// タッチ開始
			}
			else if (touch.phase == TouchPhase.Moved)
			{
				// タッチ移動
			}
			else if (touch.phase == TouchPhase.Ended)
			{
				// タッチ終了
                SceneManager.LoadScene("test");

			}
		}
		else
		{


			if (Input.GetMouseButtonDown(0))
			{

				// タッチ開始
			}
			else if (Input.GetMouseButton(0))
			{
				// タッチ移動
			}
			else if (Input.GetMouseButtonUp(0))
			{
				// タッチ終了
                SceneManager.LoadScene("test");
			}
		}

	}
}
