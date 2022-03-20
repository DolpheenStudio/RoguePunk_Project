using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumperMovement : MonoBehaviour
{
    private Player player;
    private Enemy enemy;
    public PlayerMovement playerController;
    public CharacterController enemyController;
    public GameObject metalPlatePrefab;
    public float bumperSpeed = 3f;
    public float bumperDamage = 15f;
    public float bumperAttackSpeed = 1f;

    private float nextAttack = 0f;

    void Start()
    {
        enemyController = gameObject.GetComponent<CharacterController>();
        player = FindObjectOfType<Player>();
        enemy = gameObject.GetComponent<Enemy>();
        playerController = FindObjectOfType<PlayerMovement>();
        bumperDamage += bumperDamage * (PlayerUpgrade.playerLevelIteration - 1) * 0.1f;
    }
    
    void LateUpdate()
    {
        transform.LookAt(new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z));
        if(Vector3.Distance(transform.position, player.transform.position) <= 20)
        {
            enemyController.Move(transform.forward.normalized * bumperSpeed * Time.deltaTime);
        }
        if(nextAttack > 0)
        {
            nextAttack -= Time.deltaTime;
        }
        if (Vector3.Distance(transform.position, player.transform.position) <= 2.1 && nextAttack <= 0)
        {
            nextAttack = bumperAttackSpeed;
            player.PlayerDamage(bumperDamage);
            playerController.PlayerKnockback(transform, 0.2f);
        }
        transform.position = new Vector3(transform.position.x, 0.25f, transform.position.z);
        if(enemy.currentEnemyHealth <= 0)
        {
            Death();
        }
    }
    void Death()
    {
        if(Random.value > 0.76)
        {
            Instantiate(metalPlatePrefab, new Vector3(transform.position.x, 0.5f, transform.position.z), Quaternion.Euler(0f, 0f, 0f));
        }
    }
}
