using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpperBodyMouseFacing : MonoBehaviour
{
    public GameObject cursor;
    public GameObject shootingPoint;

    void Start()
    {
    }
    void Update()
    {
        Vector3 cursorPos = new Vector3(cursor.transform.position.x, transform.position.y, cursor.transform.position.z);
        var targetRotation = Quaternion.LookRotation(cursorPos - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, 10f * Time.deltaTime);
    }
}
