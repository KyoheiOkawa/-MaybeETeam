using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreGet : MonoBehaviour {
	int score;
	public Text scoreText;

	// Use this for initialization
	void Start () {
		score = PlayerPrefs.GetInt("Score");
		scoreText.text = score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
