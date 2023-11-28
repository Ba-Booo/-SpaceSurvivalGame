using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{

    public Transform cameraPosition;
    public UIScript blind;

    public float sensX;
    public float sensY; //X와 Y의 대한 감도

    float xRotation;
    float yRotation;

    void Update()
    {   

        if(blind.blink != true)
        {
            transform.position = new Vector3( cameraPosition.position.x, cameraPosition.position.y + 1.4f, cameraPosition.position.z );

            //마우스값 input
            float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
            float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

            yRotation += mouseX;

            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            //화면 회전
            transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        }

    }
  
}
