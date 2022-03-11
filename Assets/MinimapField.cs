using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapField : MonoBehaviour
{
    private MinimapPlayerPointer player;
    private Renderer render;
    void Start()
    {
        player = FindObjectOfType<MinimapPlayerPointer>();
        render = GetComponentInChildren<Renderer>();
        render.enabled = false;
    }

    void Update()
    {
        if(Vector3.Distance(transform.position, player.transform.position) <= 30f)
        {
            render.enabled = true;
        } 
    }
}
