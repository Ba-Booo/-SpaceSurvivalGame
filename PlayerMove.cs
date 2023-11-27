using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    Vector3 moveDir;
    Rigidbody rb;       //중력
    public Transform cameraDirection;  //카메라 방향

    float MoveX, MoveZ;     //움직임
    public float Speed;

    public bool JumpPrevention;    //점프
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

        MoveX = Input.GetAxis("Horizontal");    //좌우 움직임
        MoveZ = Input.GetAxis("Vertical");      //앞뒤 움직임

        moveDir = (Vector3.forward * MoveZ) + (Vector3.right * MoveX);
        transform.Translate( moveDir * Speed * Time.deltaTime, Space.Self );

        transform.rotation = Quaternion.Euler( 0, cameraDirection.eulerAngles.y, 0 );   //회전

    }

    void Jump()
    {

        if( Input.GetKeyDown( KeyCode.Space ) && JumpPrevention == true )        //점프
        {
            rb.AddForce(transform.up * JumpPower, ForceMode.Impulse);
            JumpPrevention = false;
        } 

    }

    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            JumpPrevention = true;
        }
    }
     
}
