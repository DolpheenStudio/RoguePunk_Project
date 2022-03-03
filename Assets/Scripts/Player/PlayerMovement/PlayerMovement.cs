using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public GameObject PlayerTransform;
    public Transform cam;
    public Material damageMaterial;
    public Material standardMaterial;

    public float playerSpeed = 6f;
    public float knockBackForce = 2f;
    public float knockBackTime = 0.5f;
    private float knockBackCounter;

    private Vector3 knockBackDirection;
    private Vector3 moveDir;

    void Start()
    {
        foreach (MeshRenderer render in GetComponentsInChildren<MeshRenderer>())
        {
            if (render.name != "CursorModel") render.material = standardMaterial;
        }
    }

    void Update()
    {
        if (knockBackCounter <= 0)
        {
            foreach (MeshRenderer render in GetComponentsInChildren<MeshRenderer>())
            {
                if (render.name != "CursorModel") render.material = standardMaterial;
            }
            float horizontal = Input.GetAxisRaw("Horizontal");
            float vertical = Input.GetAxisRaw("Vertical");
            Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

            if (direction.magnitude >= 0.1f)
            {
                float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;

                moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;

                controller.Move(moveDir.normalized * playerSpeed * Time.deltaTime);

                PlayerTransform.transform.position = new Vector3(PlayerTransform.transform.position.x, 0f, PlayerTransform.transform.position.z);
            }
        }
        else
        {
            foreach(MeshRenderer render in GetComponentsInChildren<MeshRenderer>())
            {
                if (render.name != "CursorModel") render.material = damageMaterial;
            }
            controller.Move(knockBackDirection * knockBackForce * knockBackCounter);
            knockBackCounter -= Time.deltaTime;
        }
    }

    public void PlayerKnockback(Transform enemy)
    {
        knockBackDirection = enemy.forward.normalized;
        knockBackCounter = knockBackTime;
    }
}
