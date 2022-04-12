using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCursorTexture : MonoBehaviour
{
    public Texture2D clickedCursorTexture;
    public Texture2D notClickedCursorTexture;
    private CursorMode cursorMode = CursorMode.Auto;
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            Cursor.SetCursor(clickedCursorTexture, Vector2.zero, cursorMode);
        }
        else
        {
            Cursor.SetCursor(notClickedCursorTexture, Vector2.zero, cursorMode);
        }
    }
}
