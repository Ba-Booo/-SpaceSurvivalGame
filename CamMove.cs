using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{

    public Transform cameraPosition;

    public float sensX;
    public float sensY; //X와 Y의 대한 감도

    public Transform orientation;
    public Transform oon;

    float xRotation;
    float yRotation;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }


    private void Update()
    {    

        transform.position = new Vector3( cameraPosition.position.x, cameraPosition.position.y + 1.6f, cameraPosition.position.z );


        //마우스값 input
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensX;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

        yRotation += mouseX;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //화면 회전
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        orientation.rotation = Quaternion.Euler(0,yRotation, 0);

    }

    
}
