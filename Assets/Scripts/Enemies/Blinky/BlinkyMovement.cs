using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlinkyMovement : MonoBehaviour
{
    private Player player;
    private Enemy enemy;
    public PlayerMovement playerController;
    public GameObject bearingPrefab;
    public GameObject movementSphere;
    public GameObject sawBlade;
    public GameObject blinkyModel;
    public float blinkyDashForce = 5f;
    public float blinkyAttackSpeed = 4f;
    public float blinkyDamage = 10f;

    private bool damageCooldown = true;
    private bool damageDealt = false;
    public float blinkyAttackCooldown = 0f;
    private CharacterController enemyController;

    void Start()
    {
        enemy = gameObject.GetComponent<Enemy>();
        enemyController = gameObject.GetComponent<CharacterController>();
        player = FindObjectOfType<Player>();
        playerController = FindObjectOfType<PlayerMovement>();
        blinkyDamage += blinkyDamage * (PlayerUpgrade.playerLevelIteration - 1) * 0.1f;
    }

    void Update()
    {
        if(enemy.currentEnemyHealth <= 0)
        {
            Death();
        }
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

                enemyController.Move(blinkyModel.transform.forward * blinkyAttackCooldown * Time.deltaTime * blinkyDashForce);
                blinkyAttackCooldown -= Time.deltaTime;
                movementSphere.transform.rotation = movementSphere.transform.rotation * Quaternion.Euler(0f, 0f, 100f * blinkyAttackCooldown * Time.deltaTime);
                sawBlade.transform.rotation = sawBlade.transform.rotation * Quaternion.Euler(0f, 0f, 300f * blinkyAttackCooldown * Time.deltaTime);
                if (damageDealt == false) damageCooldown = true;
                else damageCooldown = false;
            }
            else
            {
                sawBlade.transform.rotation = sawBlade.transform.rotation * Quaternion.Euler(0f, 0f, 300f * (4 - blinkyAttackCooldown) * Time.deltaTime);
                blinkyAttackCooldown -= Time.deltaTime;
                damageCooldown = false;
            }
        }
        else if(blinkyAttackCooldown >= 0)
        {
            blinkyAttackCooldown = 0;
        }
        if (Vector3.Distance(transform.position, player.transform.position) <= 2.5 && damageCooldown == true)
        {
            player.PlayerDamage(blinkyDamage);
            playerController.PlayerKnockback(blinkyModel.transform, 50f);
            damageDealt = true;
        }
        transform.position = new Vector3(transform.position.x, 0.2f, transform.position.z);
    }
    void Death()
    {
        if(Random.value > 0.76)
        {
            Instantiate(bearingPrefab, new Vector3(transform.position.x, 0.5f, transform.position.z), Quaternion.Euler(0f, 0f, 0f));
        }
    }
}
