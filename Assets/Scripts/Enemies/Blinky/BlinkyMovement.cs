using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkyMovement : MonoBehaviour
{
    public Player player;
    public PlayerMovement playerController;
    public float blinkyDashForce = 5f;
    public float blinkyAttackSpeed = 4f;
    public float blinkyDamage = 10f;

    private bool damageCooldown = true;
    private bool damageDealt = false;
    private float blinkyAttackCooldown = 0f;
    private CharacterController enemyController;

    void Start()
    {
        enemyController = gameObject.GetComponent<CharacterController>();
        player = FindObjectOfType<Player>();
        playerController = FindObjectOfType<PlayerMovement>();
        blinkyDamage += blinkyDamage * (PlayerUpgrade.playerLevelIteration - 1) * 0.1f;
    }

    void LateUpdate()
    {   
        if (Vector3.Distance(transform.position, player.transform.position) <= 10) 
        {
            if (blinkyAttackCooldown <= 0)
            {
                blinkyAttackCooldown = blinkyAttackSpeed;
                damageDealt = false;
            }
            else if (blinkyAttackCooldown >= 0 && blinkyAttackCooldown <= 2)
            {

                enemyController.Move(transform.forward * blinkyAttackCooldown * Time.deltaTime * blinkyDashForce);
                blinkyAttackCooldown -= Time.deltaTime;
                if (damageDealt == false) damageCooldown = true;
                else damageCooldown = false;
            }
            else
            {
                transform.LookAt(new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z));
                blinkyAttackCooldown -= Time.deltaTime;
                damageCooldown = false;
            }
        }
        if (Vector3.Distance(transform.position, player.transform.position) <= 1.5 && damageCooldown == true)
        {
            player.PlayerDamage(blinkyDamage);
            playerController.PlayerKnockback(transform, 0.2f);
            damageDealt = true;
        }
        transform.position = new Vector3(transform.position.x, 0.2f, transform.position.z);
    }
}
