using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIScript : MonoBehaviour
{

    public bool blink;
    
    public GameObject BackGround;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {

        if( Input.GetKeyDown(KeyCode.Escape) && blink == true)
        {
            BackGround.SetActive(false);
            blink = false;
            Cursor.lockState = CursorLockMode.Locked;

        }
        else if( Input.GetKeyDown(KeyCode.Escape) && blink == false)
        {
            BackGround.SetActive(true);
            blink = true;
            Cursor.lockState = CursorLockMode.None;
        }

    }

}
