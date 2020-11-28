using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float Speed = 20f;
    public float speedH = 10f;
    float hor = 0;
    void Update()
    {
        if(Input.GetKey("w")) transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        if(Input.GetKey("s")) transform.Translate(Vector3.back * Speed * Time.deltaTime);
        if(Input.GetKey("d")) transform.Translate(Vector3.right * Speed * Time.deltaTime);
        if(Input.GetKey("a")) transform.Translate(Vector3.left * Speed * Time.deltaTime);
        hor += speedH * Input.GetAxis("Mouse X");
        transform.eulerAngles = new Vector3(0, hor, 0);
    }
}
