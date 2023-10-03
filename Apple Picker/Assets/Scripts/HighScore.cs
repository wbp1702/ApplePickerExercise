using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    static private Text uiText;
    static private int score = 1000;

	private void Awake()
	{
		uiText = GetComponent<Text>();

		if (PlayerPrefs.HasKey("HighScore")) Score = PlayerPrefs.GetInt("HighScore");

		PlayerPrefs.SetInt("HighScore", Score);
	}

	static public int Score {
		get { return score; }
		private set {
			score = value;
			PlayerPrefs.SetInt("HighScore", value);
			if (uiText != null) uiText.text = "High Score: " + value.ToString("#,0");
		}
	}

	public static void TrySetHighScore(int new_score)
	{
		if (new_score > Score) Score = new_score;
	}

	public bool resetHighScoreNow = false;

    private void OnDrawGizmos()
    {
        if (resetHighScoreNow)
		{
			resetHighScoreNow = false;
			PlayerPrefs.SetInt("HighScore", 1000);
			Debug.LogWarning("PlayerPrefs Highscore reset to 1,000");
		}
    }
}
