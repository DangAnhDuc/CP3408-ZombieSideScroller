﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{

    public float runSpeed;
    public float walkSpeed;

    Rigidbody myRB;
    Animator myAnim;

    bool facingRight;
    // Use this for initialization
    void Start()
    {
        myRB=GetComponent<Rigidbody>();
        myAnim=GetComponent<Animator>();
        facingRight = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        float move = Input.GetAxisRaw("Horizontal");
        myAnim.SetFloat("speed", Mathf.Abs(move));

        float sneaking = Input.GetAxisRaw("Fire3");
        myAnim.SetFloat("sneaking", sneaking);

        if (sneaking > 0)
        {
            myRB.velocity = new Vector3(move * walkSpeed, myRB.velocity.y, 0);
        }
        else
        {
            myRB.velocity = new Vector3(move * runSpeed, myRB.velocity.y, 0);

        }

        if (move > 0 && !facingRight) Flip();
        else if (move < 0 && facingRight) Flip();
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.z *= -1;
        transform.localScale = theScale;
    }
}
