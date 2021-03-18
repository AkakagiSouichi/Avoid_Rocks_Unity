using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cupsel : MonoBehaviour {

    public float Espeed;

    public void Start()
    {

    }
    void Update()
    {
        transform.position += new Vector3(Espeed * Time.deltaTime, -0.05f, 0f);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Finish")
        {
            Destroy(this.gameObject);
        }

        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
