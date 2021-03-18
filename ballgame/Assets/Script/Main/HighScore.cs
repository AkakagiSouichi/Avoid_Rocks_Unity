using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HighScore : MonoBehaviour {

    public Text highScoreText;
    private float highScore;
    const string key = "HIGH SCORE";

    void Start () {
        highScore = PlayerPrefs.GetFloat(key, 0);
        highScoreText.text = "HighScore: " + highScore.ToString();
    }
	
	void Update () {
		
	}
}
