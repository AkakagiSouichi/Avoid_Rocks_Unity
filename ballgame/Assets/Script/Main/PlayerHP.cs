using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour {

    public readonly int maxHP = 100;  
	public readonly int ScoreMax = 100;
    public static int HP;    
	public static float Score;
    public int EnemyATK,ScoreAtk;　　
    public Text PHP,PHP2;
    private AudioSource HIT;
    private AudioSource SCORE;
    private float timeleft;
    

    public static float getScoreCount()
    {
		return Mathf.CeilToInt(Score);
    }

    public static int getHpcount()
    {
        return HP;
    }

    void Start()
    {
        EnemyATK = 10;
        ScoreAtk = 10;
        AudioSource[] audioSources = GetComponents<AudioSource>();
        SCORE = audioSources[0];
        HIT = audioSources[1];
    
        HP = maxHP; 
		Score = ScoreMax;

        PHP.text = "HP: 10";
		PHP2.text = "Score: 100";
    }


    void Update()
	{
		Score -= Time.deltaTime;
		PHP2.text = "Score: " +  Mathf.Ceil(Score);

		if (HP <= 0 || Score <= 0)
        {
            Score = 0;
            SceneManager.LoadScene("GameOver");
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Score = 0;
            SceneManager.LoadScene("Title");
        }
    }

    void OnTriggerEnter(Collider hit)
    {

        if (hit.CompareTag("Enemy"))
        {
            HIT.PlayOneShot(HIT.clip);
            HP -= EnemyATK;
            Score -= ScoreAtk;
        }

        PHP.text = "HP: " + HP;

		if (hit.CompareTag ("Score+")) 
		{
            SCORE.PlayOneShot(SCORE.clip);
			Score += 50;
		}

        if (hit.CompareTag("Flag"))
        {
            SceneManager.LoadScene("Goal");
        }


    }
}
