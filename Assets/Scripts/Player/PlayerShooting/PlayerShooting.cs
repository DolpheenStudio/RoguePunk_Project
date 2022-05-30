using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public Player player;
    public Transform firePoint;
    public GameObject bulletPrefab;
    public GameObject shotParticle;
    private float nextFire = 0f;

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire && !IsGamePaused.isGamePaused)
        {
            Shoot();
            if(player.playerDoubleShot) StartCoroutine(DoubleShot());
        }
        Vector3 forward = firePoint.TransformDirection(Vector3.forward * 10);
    }

    IEnumerator DoubleShot()
    {
        yield return new WaitForSeconds(0.15f);
        Shoot();
    }

    void Shoot()
    {
        nextFire = Time.time + player.playerAttackSpeed;
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Instantiate(shotParticle, firePoint.position, firePoint.rotation);

        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        rb.AddForce(firePoint.forward * player.playerBulletSpeed, ForceMode.VelocityChange);
    }
}
