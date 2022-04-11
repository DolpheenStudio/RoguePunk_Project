using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorMovement : MonoBehaviour
{
    public Transform shootingPoint;
    private int groundLayerMask = 1 << 9;
    void Start()
    {

    }
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit, Mathf.Infinity, groundLayerMask) && !IsGamePaused.isGamePaused)
        {
            Vector3 mousePos = new Vector3(raycastHit.point.x, raycastHit.point.y, raycastHit.point.z);
            transform.position = mousePos;
        }

    }
}
