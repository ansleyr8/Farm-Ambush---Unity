using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    public Gun_Controller theGun;
   // public float moveSpeed;
    //private Rigidbody myRigidbody;
   // private Vector3 moveInput;
    //private Vector3 moveVelocity;

    // Start is called before the first frame update
    void Start()
    {
       // myRigidbody = GetComponent<Rigidbody>();

        
    }

    // Update is called once per frame
    void Update()
    {
        //moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), 0f, Input.GetAxisRaw("Veritical"));
        //moveVelocity = moveInput * moveSpeed;



        if (Input.GetMouseButtonDown(0))
            theGun.isFiring = true;
        
        if (Input.GetMouseButtonUp(0))
            theGun.isFiring = false;
    }

    //void FixedUpdate () 
   // {
        //myRigidbody.velocity = moveVelocity;

    //}
}
