using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperRotation : MonoBehaviour
{
    private Player player;
    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        transform.LookAt(new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z));
        transform.rotation *= Quaternion.Euler(0f, 0f, 0f);
    }
}
