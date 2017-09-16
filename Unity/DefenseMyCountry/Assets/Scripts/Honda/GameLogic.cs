using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameLogic : MonoBehaviour {
	
	private int score = 0;
	private int failureCount = 0;
	private float countTime = 0;
	private float remainingTime = 0;
	public Text scoreText;
	public Text counterText;

	void start () {
	}

	void Update () {
		countTime += Time.deltaTime;
		remainingTime = 60 - countTime;
		counterText.text = "残り時間 ： " + remainingTime.ToString("F0") + "秒";
		if (remainingTime <= 0 ) {
			PlayerPrefs.SetInt("Score", this.score);
			PlayerPrefs.Save();
			SceneManager.LoadScene ("result");
		}
		scoreText.text = "Score : " + this.score.ToString("D4") + "\nFailed : " + this.failureCount;
	}

	public void addScore () {
		this.score += 10;
	}

//	void addFailure () {
//		this.failureCount += 1;
//		if (this.failureCount == 3) {
//			this.isGameOver = true;
//		}
//	}

}