using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkyRotation : MonoBehaviour
{
    private Player player;
    private BlinkyMovement blinkyMovement;
    void Start()
    {
        player = FindObjectOfType<Player>();
        blinkyMovement = GetComponentInParent<BlinkyMovement>();
    }
    void Update()
    {
        if(blinkyMovement.blinkyAttackCooldown >= 2 && blinkyMovement.blinkyAttackCooldown <= 4)
            transform.LookAt(new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z));
    }
}
