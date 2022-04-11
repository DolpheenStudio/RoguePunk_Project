using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorPosition : MonoBehaviour
{
    void Update()
    {
        transform.position = Input.mousePosition;
    }
}
