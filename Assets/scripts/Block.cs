using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D c)
    {
        if (c.gameObject.tag == "block")
        {
            Destroy(c.gameObject);
        }

        if (c.gameObject.tag == "block_1")
        {
            Destroy(c.gameObject);
        }

        if (c.gameObject.tag == "block_2")
        {
            Destroy(c.gameObject);
        }

        if (c.gameObject.tag == "block_3")
        {
            Destroy(c.gameObject);
        }
    }

    void OnCollisionStay2D(Collision2D c)
    {

    }

    void OnCollisionExit2D(Collision2D c)
    {

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
