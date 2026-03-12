using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController2 : MonoBehaviour
{
	private float speed = 20.0f;
	
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
	public float turnSpeed;
	public float horizontalInput;
	public float forwardInput;
    void Update()
    {
		horizontalInput = Input.GetAxis("Horizontal");
		forwardInput = Input.GetAxis("Vertical");
		
		transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
		transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
		transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
	}
}
