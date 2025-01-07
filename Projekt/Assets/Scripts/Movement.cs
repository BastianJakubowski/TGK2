using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SocialPlatforms.Impl;

public class Movement : MonoBehaviour
{
    [SerializeField] float vectorX;
    [SerializeField] float vectorY = 0;
    [SerializeField] float vectorZ;
    [SerializeField] float speed = 5;
    [SerializeField] InputAction actionJump;
  
    Rigidbody rb;
    private void OnEnable()
    {
        actionJump.Enable();
    }


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        vectorX = Input.GetAxis("Horizontal");
        vectorZ = Input.GetAxis("Vertical");
        transform.Translate(vectorX * Time.deltaTime * speed, vectorY, vectorZ * Time.deltaTime * speed);

    }

    private void FixedUpdate()
    {
        if (actionJump.IsPressed())
        {
            rb.AddForce(Vector3.up * Time.fixedDeltaTime * 1000);


        }
    }
}
