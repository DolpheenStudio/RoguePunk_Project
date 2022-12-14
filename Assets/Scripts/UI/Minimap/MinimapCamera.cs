using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapCamera : MonoBehaviour
{
    public GameObject minimapCamera;
    void Start()
    {
        minimapCamera.SetActive(false);
    }

    public void SetCameraFOV(float startZ, float endZ, float startX, float endX)
    {
        if ((startZ - endZ) > (startX - endX)) 
        {
            minimapCamera.GetComponent<Camera>().fieldOfView = (startZ - endZ) / 9;
            if(minimapCamera.GetComponent<Camera>().fieldOfView <= 10) minimapCamera.GetComponent<Camera>().fieldOfView = 10;
        }
        else 
        {
            minimapCamera.GetComponent<Camera>().fieldOfView = (startX - endX) / 9;
            if(minimapCamera.GetComponent<Camera>().fieldOfView <= 10) minimapCamera.GetComponent<Camera>().fieldOfView = 10;
        }
    }
    void Update()
    {
        if (Input.GetButton("Minimap"))
        {
            minimapCamera.SetActive(true);
        }
        else
        {
            minimapCamera.SetActive(false);
        }
    }
}
