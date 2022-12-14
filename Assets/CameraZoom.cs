using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour
{
    public Camera playerCamera;
    private float maxFOV = 25;
    private float minFOV = 10;
    void Start()
    {
        playerCamera.fieldOfView = 25;
    }
    void Update()
    {
        if(Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            if(playerCamera.fieldOfView >= minFOV)
            {
                playerCamera.fieldOfView -= Time.deltaTime * 200f;
            }
        }
        if(Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            if(playerCamera.fieldOfView <= maxFOV)
            {
                playerCamera.fieldOfView += Time.deltaTime * 200f;
            }
        }
    }
}
