using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{

    Rigidbody rb;       //중력
    Slider os;      //산소
    
    public Transform AroundChunk;

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
        Chunk();
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

    void Chunk()
    {
        AroundChunk.position = new Vector3(transform.position.x, 0, transform.position.z);
    }

    void OnTriggerStay(Collider other)      //산소구역 충돌
    {
        if (other.gameObject.name == "OxygenZone")
        {
            NowOxygen += 18 * Time.deltaTime;
        }

    }
     
}
