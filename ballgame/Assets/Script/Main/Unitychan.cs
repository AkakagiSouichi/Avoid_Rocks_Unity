using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unitychan : MonoBehaviour {

    private float Speed = 4;
    private float Bspeed = 2;
	
	// Update is called once per frame
	void Update () {

        Speed = 4;

        if(Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= transform.forward * Bspeed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * Speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.position -= transform.right * Speed * Time.deltaTime;
        }

    }
}
