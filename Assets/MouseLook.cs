using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [Range(50, 100)]
    public float sensX;
    public float sensY;


    public Transform oreintation;

     float xRotation;
     float yRotation;

    private void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * sensX * Time.deltaTime;
        float mouseY = Input.GetAxisRaw("Mouse Y") * sensY * Time.deltaTime;


        yRotation += mouseX;
        xRotation -= mouseY;


        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
        oreintation.rotation = Quaternion.Euler(xRotation, yRotation, 0);



    }

}
