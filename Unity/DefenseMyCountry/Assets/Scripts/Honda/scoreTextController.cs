using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreTextController : MonoBehaviour {

	public Text scoreText;
	public int score = 0;

	// Use this for initialization
	void Start () {
		PlayerPrefs.SetInt("Score", 0);
		PlayerPrefs.Save();
	}
	
	// Update is called once per frame
	void Update () {		
		score = PlayerPrefs.GetInt("Score", score);
		scoreText.text = "得点 :" + score;
	}
}
