using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IzzyBulletScript : MonoBehaviour
{

    public Player player;
    public PlayerMovement playerController;

    private Enemy enemy;

    void Start()
    {
        enemy = FindObjectOfType<Enemy>();
        player = FindObjectOfType<Player>();
        playerController = FindObjectOfType<PlayerMovement>();
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision coll)
    {
        Destroy(gameObject);
        if (coll.gameObject.tag == "Player")
        {
            player.PlayerDamage(enemy.enemyDamage);
            playerController.PlayerKnockback(transform, 0.2f);
        }
    }
}
