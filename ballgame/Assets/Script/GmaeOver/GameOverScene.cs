using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameOverScene : MonoBehaviour {

    public Text lesultscore;
	void Start () {
        float Lscore = PlayerHP.getScoreCount();
        lesultscore.text = "Score: " + Lscore;
	}
	
	void Update () {
        if (Input.anyKey)
        {
            SceneManager.LoadScene("Title");
        }
    }
}
