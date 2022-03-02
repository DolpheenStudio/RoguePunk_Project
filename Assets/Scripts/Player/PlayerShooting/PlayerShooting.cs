using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Player player;
    public Transform firePoint;
    public GameObject bulletPrefab;
    public Transform cursor;
    private float nextFire = 0f;

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        nextFire = Time.time + player.playerAttackSpeed;
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);

        Rigidbody rb = bullet.GetComponent < Rigidbody >();
        rb.AddForce(firePoint.forward * player.playerBulletSpeed, ForceMode.VelocityChange);
    }
}
