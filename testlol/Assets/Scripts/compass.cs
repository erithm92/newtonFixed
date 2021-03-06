﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class compass : MonoBehaviour
{
    public GameObject ball,magText,paddle;
    Rigidbody2D ballrb;
	// Use this for initialization
	void Start ()
    {
        ballrb = ball.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
            Vector3 moveDirection = ballrb.velocity;
            if (moveDirection != Vector3.zero)
            {
                float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
                Quaternion targetRot = Quaternion.AngleAxis(-angle, Vector3.forward);
                transform.rotation = Quaternion.RotateTowards(transform.rotation, targetRot, 300 * Time.deltaTime);
            }
            if(paddle.GetComponent<PaddleBehavior>().paused == false)
                magText.GetComponent<Text>().text = Mathf.RoundToInt(ballrb.velocity.magnitude) + "m/s";
        //transform.position = ball.transform.position;
    }
}
