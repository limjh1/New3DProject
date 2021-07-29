using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed = 10f;
    public float inputHorizontalValue;
    public float inputVerticalValue;

    void Start()
    {
        
    }
    void Update()
    {
        inputHorizontalValue = Input.GetAxis("Horizontal");
        inputVerticalValue = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * inputVerticalValue);
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * inputHorizontalValue);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * inputHorizontalValue);
    }
}
