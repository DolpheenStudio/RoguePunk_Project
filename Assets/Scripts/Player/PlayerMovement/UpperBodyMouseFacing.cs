using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpperBodyMouseFacing : MonoBehaviour
{
    GameObject cursor;

    void Start()
    {
        cursor = GameObject.Find("Cursor");
    }
    void Update()
    {
        Vector3 cursorPosition = new Vector3(cursor.transform.position.x, transform.position.y, cursor.transform.position.z);
        transform.LookAt(cursorPosition);
    }
}
