using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class setumei : MonoBehaviour {

    private AudioSource kettei;

    private void Start()
    {
        kettei = GetComponent<AudioSource>();
    }

    void Update () {
		if (Input.anyKeyDown)
        {
            kettei.PlayOneShot(kettei.clip);
            Invoke("DelayMethod", 0.2f);
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Title");
        }

	}
    void DelayMethod()
    {
        SceneManager.LoadScene("main");
    }
}
