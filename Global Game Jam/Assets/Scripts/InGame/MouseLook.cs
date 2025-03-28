﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField]
    private GameManager gm = null;

    public float mouseSensitivity = 100f;

    [SerializeField]
    private Transform playerBody = null;

    private float xRotation = 0f;

    void Start()
    {
        
    }

    
    void Update()
    {
        if(!gm.isPaused)
        {
            CameraMovement();
        }
        else
        {

        }
    }

    private void CameraMovement()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation,0,0);
        playerBody.Rotate(Vector3.up * mouseX);

    }


}
