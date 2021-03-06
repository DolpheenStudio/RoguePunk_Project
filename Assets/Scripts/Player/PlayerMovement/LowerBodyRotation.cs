using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowerBodyRotation : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;

    public float speed = 6f;

    float turnSmoothVelocity;

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f && !IsGamePaused.isGamePaused)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, 0.3f);

            transform.rotation = Quaternion.Euler(0f, angle, 0f);
            transform.rotation = transform.rotation * Quaternion.Euler(0f, 0f, Time.deltaTime * 100f);
        }
    }
}
