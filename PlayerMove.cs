using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    Rigidbody rb;

    float MoveX;
    float MoveZ;


    void Start()
    {
        
    }


    void Update()
    {

        MoveX = Input.GetAxis("Horizontal") * Time.deltaTime;   //좌우 움직임
        MoveZ = Input.GetAxis("Vertical") * Time.deltaTime;   //좌우 움직임

        transform.position = new Vector3(transform.position.x + MoveX, transform.position.y, transform.position.z + MoveZ );

    }
}
