using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public GameObject PlayerTransform;
    public Transform cam;

    public float speed = 6f;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

            controller.Move(moveDir.normalized * speed * Time.deltaTime);

            PlayerTransform.transform.position = new Vector3(PlayerTransform.transform.position.x, 0f, PlayerTransform.transform.position.z);
        }
    }
}
