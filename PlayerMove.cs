using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    Rigidbody rb;

    float MoveX;
    float MoveZ;

    public float Speed;
    public float JumpPower;


    void Start()
    {

        rb = GetComponent<Rigidbody>();
        
    }


    void Update()
    {   
        Move();
        Jump();
    }



    void Move()
    {

        MoveX = Input.GetAxis("Horizontal") * Speed * Time.deltaTime;   //좌우 움직임
        MoveZ = Input.GetAxis("Vertical") * Speed * Time.deltaTime;   //앞뒤 움직임

        transform.position = new Vector3(transform.position.x + MoveX, transform.position.y, transform.position.z + MoveZ );

    }


    void Jump()
    {

       if ( Input.GetKeyDown( KeyCode.Space ) )        //점프
        {
            rb.AddForce(transform.up * JumpPower, ForceMode.Impulse);
        } 

    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "OxygenArea")
        {
            Debug.Log("test");
        }

    }

    
}
