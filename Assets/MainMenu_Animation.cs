using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu_Animation : MonoBehaviour
{
    private float movementCooldown = 1.6f;

    void Update()
    {
        if(movementCooldown <= 3f)
        {
            transform.position += new Vector3(0f, 0.5f * Time.deltaTime, 0f);
            movementCooldown += Time.deltaTime;
        }
        else if(movementCooldown >= 3f)
        {
            transform.position -= new Vector3(0f, 0.5f * Time.deltaTime, 0f);
            movementCooldown += Time.deltaTime;
            if(movementCooldown >= 6) movementCooldown = 0f;
        }
    }
}
