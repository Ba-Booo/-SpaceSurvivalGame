using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OxygenGauge : MonoBehaviour
{

    Slider Oxygen;

    public float NowOxygen;
    public float MaxOxygen;


    void Start()
    {
        Oxygen = GetComponent<Slider>();

    }


    void Update()
    {
        Oxygen.value = NowOxygen / MaxOxygen;

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
}
