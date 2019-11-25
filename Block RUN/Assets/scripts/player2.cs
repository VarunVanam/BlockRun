﻿
using UnityEngine;

public class player2 : MonoBehaviour {

    public Rigidbody rb;
    public float forwardForce=2000f;
    public float sidewayForce = 500f;
	// Update is called once per frame
	void FixedUpdate () {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        if(Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y <-1f)
        {
            FindObjectOfType<restartgame>().Endgame();
        }
	}

}
