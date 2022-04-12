using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IzzyMovement : MonoBehaviour
{
    public Player player;
    public GameObject izzyBulletPrefab;
    public Transform shootingPoint;
    public GameObject gunPowderPrefab;
    public float izzyBulletSpeed = 1f;
    public float izzyAttackSpeed = 1.5f;

    private Enemy enemy;
    private float izzyAttackCooldown = 0f;

    void Start()
    {
        enemy = gameObject.GetComponent<Enemy>();
        player = FindObjectOfType<Player>();
    }

    void LateUpdate()
    {
        
        shootingPoint.transform.LookAt(new Vector3(player.transform.position.x, shootingPoint.transform.position.y, player.transform.position.z));
        if (Vector3.Distance(transform.position, player.transform.position) <= 10)
        {
            if (izzyAttackCooldown <= 0)
            {
                izzyAttackCooldown = izzyAttackSpeed;
                Shoot();
            }
            else izzyAttackCooldown -= Time.deltaTime;
        }
        if(enemy.currentEnemyHealth <= 0)
        {
            Death();
        }
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(izzyBulletPrefab, shootingPoint.position, shootingPoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(shootingPoint.forward * izzyBulletSpeed, ForceMode.VelocityChange);
    }
    void Death()
    {
        if(Random.value > 0.76)
        {
            Instantiate(gunPowderPrefab, new Vector3(transform.position.x, 0.5f, transform.position.z), Quaternion.Euler(0f, 0f, 0f));
        }
    }
}
