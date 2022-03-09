using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpperBodyMouseFacing : MonoBehaviour
{
    public GameObject cursor;

    void Start()
    {
    }
    void Update()
    {
        Vector3 cursorPosition = new Vector3(cursor.transform.position.x, cursor.transform.position.y - 1.1f, cursor.transform.position.z);
        transform.LookAt(cursorPosition);

        if(transform.localRotation.eulerAngles.x >= 45 && transform.localRotation.eulerAngles.x <= 90) 
        {
            transform.eulerAngles = new Vector3(45f, transform.eulerAngles.y, transform.eulerAngles.z);
        }
    }
}
