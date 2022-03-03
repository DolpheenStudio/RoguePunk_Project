using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IzzyMovement : MonoBehaviour
{
    public Player player;
    public GameObject izzyBulletPrefab;
    public Transform shootingPoint;
    public float izzyAttackSpeed = 1f;
    public float izzyAttackCooldown = 0f;
    public float izzyBulletSpeed = 1f;

    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        shootingPoint.transform.LookAt(new Vector3(player.transform.position.x, player.transform.position.y + 0.8f, player.transform.position.z));
        if (Vector3.Distance(transform.position, player.transform.position) <= 10)
        {
            if (izzyAttackCooldown <= 0)
            {
                izzyAttackCooldown = izzyAttackSpeed;
                Shoot();
            }
            else izzyAttackCooldown -= Time.deltaTime;
        }
    }
    void Shoot()
    {
        GameObject bullet = Instantiate(izzyBulletPrefab, shootingPoint.position, shootingPoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(shootingPoint.forward * izzyBulletSpeed, ForceMode.VelocityChange);
    }
}
