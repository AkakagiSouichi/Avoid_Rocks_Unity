using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour {

    private AudioSource kettei;
    public static float _Fcount;

    private void Start()
    {
        kettei = GetComponent<AudioSource>();
    }

    public static float GetFcount ()
    {
        return _Fcount;
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            {
                _Fcount = 1.0f;
                kettei.PlayOneShot(kettei.clip);
                Invoke("DelayMethod", 0.2f);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            {
                _Fcount = 0.5f;
                kettei.PlayOneShot(kettei.clip);
                Invoke("DelayMethod", 0.2f);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            {
                _Fcount = 0.2f;
                kettei.PlayOneShot(kettei.clip);
                Invoke("DelayMethod", 0.2f);
            }
        }

    }
    void DelayMethod()
    {
        SceneManager.LoadScene("setumei");
    }
}
