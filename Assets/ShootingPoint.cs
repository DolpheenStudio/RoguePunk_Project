using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingPoint : MonoBehaviour
{
    public GameObject cursor;
    void FixedUpdate()
    {
        if(Vector3.Distance(transform.position, cursor.transform.position) >= 1.8f) transform.LookAt(new Vector3(cursor.transform.position.x, transform.position.y, cursor.transform.position.z));
    }
}
