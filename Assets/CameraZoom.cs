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
            Debug.Log("Scroll");
            if(playerCamera.fieldOfView >= minFOV)
            {
                Debug.Log("Zoom");
                playerCamera.fieldOfView -= Time.deltaTime * 200f;
            }
        }
        if(Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            Debug.Log("Scroll");
            if(playerCamera.fieldOfView <= maxFOV)
            {
                Debug.Log("Zoom");
                playerCamera.fieldOfView += Time.deltaTime * 200f;
            }
        }
    }
}
