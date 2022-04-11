using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingPoint : MonoBehaviour
{
    public GameObject cursor;
    void FixedUpdate()
    {
        if(Vector3.Distance(transform.position, cursor.transform.position) >= 1.8f && cursor.transform.position.y - transform.position.y <= 3f) 
        {
            Vector3 cursorPos = new Vector3(cursor.transform.position.x + 0.5f, transform.position.y, cursor.transform.position.z + 0.5f);
            var targetRotation = Quaternion.LookRotation(cursorPos - transform.position);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 20f * Time.deltaTime);
        }
    }
}
