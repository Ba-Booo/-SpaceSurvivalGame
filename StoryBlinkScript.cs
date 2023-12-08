using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryBlinkScript : MonoBehaviour
{

    public bool blink;

    public GameObject BackGround;

    public void Story()
    {
        BackGround.SetActive(true);
        blink = true;
    }
    
    void Update()
    {

        if( Input.GetKeyDown(KeyCode.Escape) && blink == true)
        {

            BackGround.SetActive(false);
            blink = false;

        }

    }

}
