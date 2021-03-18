using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour {

   private float Espeed;
   
	public void Start(){
        Espeed = 10;
    }
    void Update () 
	{
        transform.position += new Vector3( Espeed*Time.deltaTime, -0.05f, 0f);
        transform.Rotate(new Vector3(0, 0, -5.0f));
	}

	private void OnCollisionEnter(Collision collision)
	{
		if(collision.gameObject.tag == "Finish")
		{
			Destroy(this.gameObject);
		}

		if(collision.gameObject.tag == "Player")
		{
			Destroy(this.gameObject);
		}
	}
}
