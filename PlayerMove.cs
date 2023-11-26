using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{

    Rigidbody rb;       //중력
    Slider os;      //산소
    public Transform cameraDirection;  //카메라 방향

    float MoveX, MoveZ;

    public float Speed;
    public float JumpPower;
    public float NowOxygen;
    public float MaxOxygen;



    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        os = GameObject.Find("OxygenSlider").GetComponent<Slider>();
        
    }


    void Update()
    {   
        Move();
        Jump();
        OxygenGauge();
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

    void OxygenGauge()
    {

        os.value = NowOxygen / MaxOxygen;       //산소게이지
        
        if( NowOxygen <= 0 )        //0 이상 MaxOxygen 이하
        {
            NowOxygen = 0;
        }
        else if( NowOxygen > MaxOxygen)
        {
            NowOxygen = MaxOxygen;
        }
        else
        {
            NowOxygen -= 1 * Time.deltaTime;
        }

    }

    void OnTriggerStay(Collider other)      //산소구역 충돌
    {
        if (other.gameObject.name == "OxygenZone")
        {
            NowOxygen += 18 * Time.deltaTime;
        }

    }
     
}
