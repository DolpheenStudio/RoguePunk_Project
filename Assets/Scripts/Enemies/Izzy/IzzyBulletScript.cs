using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IzzyBulletScript : MonoBehaviour
{

    public Player player;
    public PlayerMovement playerController;

    public float izzyDamage = 5f;


    void Start()
    {
        player = FindObjectOfType<Player>();
        playerController = FindObjectOfType<PlayerMovement>();
        izzyDamage += izzyDamage * (PlayerUpgrade.playerLevelIteration - 1) * 0.1f;
    }

    void Update()
    {
        //transform.rotation *= Quaternion.Euler(0f, 300f * Time.deltaTime, 0f);
    }

    void OnCollisionEnter(Collision coll)
    {
        Destroy(gameObject);
        if (coll.gameObject.tag == "Player" && player.playerDamageCooldown <= 0)
        {
            player.PlayerDamage(izzyDamage);
            playerController.PlayerKnockback(transform, 50f);
        }
    }
}
