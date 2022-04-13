using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetCursorTexture : MonoBehaviour
{
    public Texture2D clickedCursorTexture;
    public Texture2D notClickedCursorTexture;
    private CursorMode cursorMode = CursorMode.Auto;
    private Vector2 middle;
    void Start()
    {
        middle = new Vector2(clickedCursorTexture.height / 2, clickedCursorTexture.width / 2);
    }

    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            Cursor.SetCursor(clickedCursorTexture, middle, cursorMode);
        }
        else
        {
            Cursor.SetCursor(notClickedCursorTexture, middle, cursorMode);
        }
    }
}
