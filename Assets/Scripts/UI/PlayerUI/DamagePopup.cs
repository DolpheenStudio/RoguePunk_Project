using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePopup : MonoBehaviour
{
    private float cooldown = 0.5f;
    void Update()
    {
        transform.LookAt(Camera.main.transform);
        transform.position += new Vector3(0f, 5f * Time.deltaTime, 0f);

        transform.localScale += new Vector3(2f * Time.deltaTime, 2f * Time.deltaTime, 2f * Time.deltaTime);

        cooldown -= Time.deltaTime;
        Debug.Log(cooldown);
        if(cooldown <= 0f) Destroy(gameObject);
    }
}
