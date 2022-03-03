using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject playerTransform;

    private Vector3 _cameraOffset;

    [Range(0.01f, 1.0f)]
    public float smoothFactor = 0.5f;

    void Start()
    {
        _cameraOffset = transform.position - playerTransform.transform.position;
        transform.position = playerTransform.transform.position + _cameraOffset;
    }

    void Update()
    {
        Vector3 newPos = playerTransform.transform.position + _cameraOffset;

        transform.position = Vector3.Slerp(transform.position, newPos, smoothFactor);
    }
}
