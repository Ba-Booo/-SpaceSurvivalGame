using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{

    public GameObject MenuSet;

    void Start()
    {
        
    }

    void Update()
    {

        if( Input.GetKey(KeyCode.E) )
        {
            MenuSet.SetActive(false);
        }
        else
        {
            MenuSet.SetActive(true);
        }

    }

}
