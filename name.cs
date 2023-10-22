using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class name : MonoBehaviour
{
    Rigidbody rb;       //중력
    Transform ro;
    public Transform target;

    float MoveX, MoveZ;

    public float Speed;
    public float JumpPower;
    
    void Start()
    {

        rb = GetComponent<Rigidbody>();
        ro = GetComponent<Transform>();
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
        transform.rotation = Quaternion.Euler(0 ,target.rotation.y, 0);

    }

    void Jump()
    {

       if ( Input.GetKeyDown( KeyCode.Space ) )        //점프
        {
            rb.AddForce(transform.up * JumpPower, ForceMode.Impulse);
        } 

    }

    
}
