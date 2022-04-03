using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerBodySphereRotation : MonoBehaviour
{
    public Transform lowerBody;
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f && !IsGamePaused.isGamePaused)
        {
            transform.rotation = transform.rotation * Quaternion.Euler(150f  * Time.deltaTime, 0f, 0f);
        }
    }
}
