using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public const int CONST_GAME_OVER_COUNT = 3;
	private bool isGameOver = false;
	private int score = 0;
	private int failureCount = 0;
	public Text scoreText;

	void start () {
	}

	void Update () {
		if (this.isGameOver)
		{			
			PlayerPrefs.SetInt("Score", this.score);
			PlayerPrefs.Save();
			SceneManager.LoadScene ("resultScene");
		}
		scoreText.text = "Score : " + this.score.ToString("D4") + "\nFailed : " + this.failureCount;
	}

	void addScore () {
		this.score += 10;
	}

	void addFailure () {
		this.failureCount += 1;
		if (this.failureCount == 3) {
			this.isGameOver = true;
		}
	}

}

