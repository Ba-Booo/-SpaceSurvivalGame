using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenGauge : MonoBehaviour
{

    Slider Oxygen;

    public float CurOxygen;
    public float MaxOxygen;


    void Start()
    {
        Oxygen = GetComponent<Slider>();

    }


    void Update()
    {
        Oxygen.value = CurOxygen / MaxOxygen;

        if( CurOxygen >= 0 )        //0미만으로 안 떨어지게 하는 용도
        {
            CurOxygen -= 1 * Time.deltaTime;
        }
        else
        {
            CurOxygen = 0;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "OxygenArea")
        {
            CurOxygen += 5 * Time.deltaTime;
            Debug.Log("ttlqkf");
        }

    }


}
