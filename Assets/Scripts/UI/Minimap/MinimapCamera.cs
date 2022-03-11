using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapCamera : MonoBehaviour
{
    public GameObject minimapCamera;
    private Camera camera;
    void Start()
    {
        minimapCamera.SetActive(false);
        camera = minimapCamera.GetComponent<Camera>();
    }

    public void SetCameraFOV(float startZ, float endZ, float startX, float endX)
    {
        if ((startZ - endZ) > (startX - endX)) camera.fieldOfView = (startZ - endZ) / 9;
        else camera.fieldOfView = (startX - endX) / 9;
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
