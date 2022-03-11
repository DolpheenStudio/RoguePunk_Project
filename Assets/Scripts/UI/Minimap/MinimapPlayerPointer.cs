using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinimapPlayerPointer : MonoBehaviour
{
    Player player;
    void Start()
    {
        player = FindObjectOfType<Player>();
    }
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x + 1000, player.transform.position.y + 5, player.transform.position.z);
    }
}
