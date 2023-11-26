using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    Rigidbody rb;       //중력
    public Transform cameraDirection;  //카메라 방향

    float MoveX, MoveZ;

    public float Speed;
    public float JumpPower;
    public float NowOxygen;
    public float MaxOxygen;



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

        MoveX = Input.GetAxis("Horizontal");   //좌우 움직임
        MoveZ = Input.GetAxis("Vertical");   //앞뒤 움직임

        Vector3 moveDir = (Vector3.forward * MoveZ) + (Vector3.right * MoveX);

        transform.Translate( moveDir * Speed * Time.deltaTime, Space.Self );

        transform.rotation = Quaternion.Euler( 0, cameraDirection.eulerAngles.y, 0 );

    }

    void Jump()
    {

       if ( Input.GetKeyDown( KeyCode.Space ) )        //점프
        {
            rb.AddForce(transform.up * JumpPower, ForceMode.Impulse);
        } 

    }
     
}
