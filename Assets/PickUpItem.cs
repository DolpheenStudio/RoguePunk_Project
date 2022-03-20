using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    private Player player;
    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        transform.rotation = transform.rotation * Quaternion.Euler(0f, Time.deltaTime * 50f, 0f);
    }
}
