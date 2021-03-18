using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class highscre : MonoBehaviour {


    public Text highScoreText,resultscore; //ハイスコアを表示するText
    private float highScore; //ハイスコア用変数
    const string key = "HIGH SCORE"; //ハイスコアの保存先キー

    void Start()
    {
        float dif = Title.GetFcount();
        float score = PlayerHP.getScoreCount();
        highScore = PlayerPrefs.GetFloat(key, 0);

        if(dif == 0.5f)
        {
            score += 500;
        }

        if (dif == 0.2f)
        {
            score += 1000;
        }

        resultscore.text = "Score: " + score;
        
        highScoreText.text = "HighScore: " + highScore.ToString();
        
        if (score > highScore)
        {
            highScore = score;
            

            PlayerPrefs.SetFloat(key, highScore);
            

            highScoreText.text = "HighScore: " + highScore.ToString();
            

            PlayerPrefs.Save();
        }
    }

    private void Update()
    {
        if (Input.anyKey)
        {
            SceneManager.LoadScene("Title");
        }

        if (Input.GetKey(KeyCode.Alpha0))
        {
            PlayerPrefs.DeleteAll();
        }
    }
}
