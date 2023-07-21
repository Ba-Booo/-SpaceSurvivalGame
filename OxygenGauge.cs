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

        if( CurOxygen <= 0 )        //0 이상 MaxOxygen 이하
        {
            CurOxygen = 0;
        }
        else if( CurOxygen > MaxOxygen)
        {
            CurOxygen = MaxOxygen;
        }
        else
        {
            CurOxygen -= 1 * Time.deltaTime;
        }
    }
}
