﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fish : MonoBehaviour
{
    //this is the variable that manipulates the force 
    [SerializeField]
    private float _force = 1000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if the spacebar is pressed then the fish would jump 
        bool pressedJumpButton = Input.GetButtonDown("Jump");

        //if spacebar is pressed
        if(pressedJumpButton)
        {
            Debug.Log("The space bar was pressed");
            //storing our rigidbody2d component into the variabe rigidbody
            Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
            //Set rigidbody velocity to zero
            //Vector3(0,0,0) Vector3(x,y,z)
            rigidbody.velocity = Vector3.zero;
            //add upwards force to rigidbody
            //Vector3 (0,1,0) * force(1000f)
            rigidbody.AddForce(Vector3.up * _force);
        }
        //if the position of the fish on the y axis is smaller than -6 reset the scene
        if(transform.position.y < -6f)
        {
            SceneManager.LoadScene(0);
        }

        //if the position of the fish on the y axis is higher than 6 reset the scene
        if(transform.position.y > 6f)
        {
            SceneManager.LoadScene(0);
        }
        //if the position of the fish on the y axis is < than -6f OR > 6f
        if(transform.position.y < -6f || transform.position.y > 6f)
        {
            SceneManager.LoadScene(0);
        }
    }
}
