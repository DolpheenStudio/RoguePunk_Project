using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUpperBodyAngle : MonoBehaviour
{
    GameObject cursor;
    void Start()
    {
        cursor = GameObject.Find("Cursor");
    }
    void Update()
    {
        transform.LookAt(cursor.transform);
    }
}
