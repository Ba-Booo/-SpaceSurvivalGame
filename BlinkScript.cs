using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkScript : MonoBehaviour
{
    
    public bool blink;

    public GameObject BackGround;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {

        if( Input.GetKeyDown(KeyCode.Escape) && blink == false)
        {

            BackGround.SetActive(true);
            blink = true;
            Cursor.lockState = CursorLockMode.None;

        }

    }

}