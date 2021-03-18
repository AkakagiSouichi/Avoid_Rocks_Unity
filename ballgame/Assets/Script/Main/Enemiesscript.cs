using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemiesscript : MonoBehaviour {

    public GameObject En,_Score;
    public float z1;
    public float z2;
    public float y;
    public float x;
    public float timeleft;

    float fcount = Title.GetFcount();


    // Use this for initialization
    void Start() {

		timeleft = 0;
        StartCoroutine(loop());
    }
    public IEnumerator loop()
    {

        while (true)
        {
            yield return new WaitForSeconds(fcount);
            onTimer();
        }
    }

    private void onTimer()
    {
        float z = Random.Range(z1, z2);

        Instantiate(En, new Vector3(x, y, z), Quaternion.identity);
    }

    // Update is called once per frame
    void Update() {
		timeleft -= Time.deltaTime;

		if (timeleft < 0)
		{
			timeleft = fcount*5;
			float z = Random.Range (z1, z2);
			Instantiate (_Score, new Vector3 (x, y, z), Quaternion.identity);
		}
    }


}
