using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public GameObject MenuSet;

    bool blink;

    void Start()
    {
        
    }

    void Update()
    {

        if( Input.GetKeyDown(KeyCode.E) && blink == true)
        {
            MenuSet.SetActive(false);
            blink = false;
        }
        else if( Input.GetKeyDown(KeyCode.E) && blink == false)
        {
            MenuSet.SetActive(true);
            blink = true;
        }

    }

}
