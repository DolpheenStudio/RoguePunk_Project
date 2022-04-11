using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Crush : MonoBehaviour
{
    public float dashTimer = 0f;
    public float shootTimer = 0f;
    public float followTimer = 0f;
    public float crushShootingCooldown = 0.25f;
    public GameObject sawBlade1;
    public GameObject sawBlade2;
    public GameObject movementSphere;
    public GameObject crushBody;
    public Material standardMaterial;
    public Material damageMaterial;
    public GameObject scrapPrefab;
    public GameObject nutPrefab;
    public GameObject boltPrefab;
    public Transform shootingPoint1;
    public Transform shootingPoint2;
    public Transform shootingPoint3;
    public Transform shootingPoint4;
    public GameObject izzyBulletPrefab;
    public Slider slider;
    private CharacterController controller;
    private Player player;
    private PlayerMovement playerController;
    private float crushDashDamage = 10f;
    private bool[] damageDealt = new bool[3];
    public float crushHealth;
    private float isDamageMaterial = 0f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        player = FindObjectOfType<Player>();
        playerController = FindObjectOfType<PlayerMovement>();
        damageDealt[0] = false;
        damageDealt[1] = false;
        damageDealt[2] = false;
        crushHealth = 1000;
        slider.maxValue = crushHealth;
        slider.value = crushHealth;
    }

    
    void Update()
    {
        //Dash Attack
        if(dashTimer >= 9)
        {
            sawBlade1.transform.rotation = sawBlade1.transform.rotation * Quaternion.Euler(0f, 200f * (12f - dashTimer) * Time.deltaTime, 0f);
            sawBlade2.transform.rotation = sawBlade2.transform.rotation * Quaternion.Euler(0f, -200f * (12f - dashTimer) * Time.deltaTime, 0f);

            transform.LookAt(new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z));
        }
        else if(dashTimer >=7 && dashTimer <= 9)
        {
            sawBlade1.transform.rotation = sawBlade1.transform.rotation * Quaternion.Euler(0f, 600f * Time.deltaTime, 0f);
            sawBlade2.transform.rotation = sawBlade2.transform.rotation * Quaternion.Euler(0f, -600f * Time.deltaTime, 0f);

            controller.Move(transform.forward * (dashTimer - 7) * Time.deltaTime * 10f);
            movementSphere.transform.rotation = movementSphere.transform.rotation * Quaternion.Euler(100f * Time.deltaTime * (dashTimer - 7), 0f, 0f);

            if(Vector3.Distance(transform.position, player.transform.position) <= 3.2)
            {
                if(damageDealt[0] == false)
                {
                    player.PlayerDamage(crushDashDamage);
                    playerController.PlayerKnockback(transform, 100f);
                    damageDealt[0] = true;
                }
            }
        }
        else if(dashTimer >=5 && dashTimer <= 7)
        {
            if(dashTimer > 6.95) transform.LookAt(new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z));  
            sawBlade1.transform.rotation = sawBlade1.transform.rotation * Quaternion.Euler(0f, 600f * Time.deltaTime, 0f);
            sawBlade2.transform.rotation = sawBlade2.transform.rotation * Quaternion.Euler(0f, -600f * Time.deltaTime, 0f);

            controller.Move(transform.forward * (dashTimer - 5) * Time.deltaTime * 10f);
            movementSphere.transform.rotation = movementSphere.transform.rotation * Quaternion.Euler(100f * Time.deltaTime * (dashTimer - 5), 0f, 0f);

            if(Vector3.Distance(transform.position, player.transform.position) <= 3.2)
            {
                if(damageDealt[1] == false)
                {
                    player.PlayerDamage(crushDashDamage);
                    playerController.PlayerKnockback(transform, 100f);
                    damageDealt[1] = true;
                }
            }

        }
        else if(dashTimer >=3 && dashTimer <= 5)
        {
            if(dashTimer > 4.95) transform.LookAt(new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z));  

            sawBlade1.transform.rotation = sawBlade1.transform.rotation * Quaternion.Euler(0f, 600f * Time.deltaTime, 0f);
            sawBlade2.transform.rotation = sawBlade2.transform.rotation * Quaternion.Euler(0f, -600f * Time.deltaTime, 0f);

            controller.Move(transform.forward * (dashTimer - 3) * Time.deltaTime * 10f);
            movementSphere.transform.rotation = movementSphere.transform.rotation * Quaternion.Euler(100f * Time.deltaTime * (dashTimer - 3), 0f, 0f);

            if(Vector3.Distance(transform.position, player.transform.position) <= 3.2)
            {
                if(damageDealt[2] == false)
                {
                    player.PlayerDamage(crushDashDamage);
                    playerController.PlayerKnockback(transform, 100f);
                    damageDealt[2] = true;
                }
            }
        }
        else if(dashTimer >=0 && dashTimer <= 3)
        {
            sawBlade1.transform.rotation = sawBlade1.transform.rotation * Quaternion.Euler(0f, 200f * dashTimer * Time.deltaTime, 0f);
            sawBlade2.transform.rotation = sawBlade2.transform.rotation * Quaternion.Euler(0f, -200f * dashTimer * Time.deltaTime, 0f);

            damageDealt[0] = false;
            damageDealt[1] = false;
            damageDealt[2] = false;
        }

        if(dashTimer >= 0) dashTimer -= Time.deltaTime;

        //Shoot Attack

        if(shootTimer >= 5 && shootTimer <= 7)
        {
            crushBody.transform.rotation = crushBody.transform.rotation * Quaternion.Euler(0f, 50f * Time.deltaTime, 0f);
        }
        else if(shootTimer >= 0 && shootTimer <= 5)
        {
            crushBody.transform.rotation = crushBody.transform.rotation * Quaternion.Euler(0f, 50f * Time.deltaTime, 0f);
            if(crushShootingCooldown <= 0)
            {
                GameObject bullet1 = Instantiate(izzyBulletPrefab, shootingPoint1.position, shootingPoint1.rotation);
                Rigidbody rb1 = bullet1.GetComponent<Rigidbody>();
                rb1.AddForce(shootingPoint1.forward * 10f, ForceMode.VelocityChange);

                GameObject bullet2 = Instantiate(izzyBulletPrefab, shootingPoint2.position, shootingPoint2.rotation);
                Rigidbody rb2 = bullet2.GetComponent<Rigidbody>();
                rb2.AddForce(shootingPoint2.forward * 10f, ForceMode.VelocityChange);

                GameObject bullet3 = Instantiate(izzyBulletPrefab, shootingPoint3.position, shootingPoint3.rotation);
                Rigidbody rb3 = bullet3.GetComponent<Rigidbody>();
                rb3.AddForce(shootingPoint3.forward * 10f, ForceMode.VelocityChange);

                GameObject bullet4 = Instantiate(izzyBulletPrefab, shootingPoint4.position, shootingPoint4.rotation);
                Rigidbody rb4 = bullet4.GetComponent<Rigidbody>();
                rb4.AddForce(shootingPoint4.forward * 10f, ForceMode.VelocityChange);

                crushShootingCooldown = 0.25f;
            }
            else crushShootingCooldown -= Time.deltaTime;
        }

        if(shootTimer >= 0) shootTimer -= Time.deltaTime;

        //Follow Attack

        if(followTimer >= 0)
        {
            transform.LookAt(new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z));
            controller.Move(transform.forward * Time.deltaTime * 5f);
            movementSphere.transform.rotation = movementSphere.transform.rotation * Quaternion.Euler(100f * Time.deltaTime, 0f, 0f);

            if(Vector3.Distance(transform.position, player.transform.position) <=3.2)
            {
                player.PlayerDamage(crushDashDamage);
                playerController.PlayerKnockback(transform, 100f);
            }
        }

        if(followTimer >= 0) followTimer -= Time.deltaTime;

        //Attack randomizer

        if(dashTimer <= 0 && shootTimer <= 0 && followTimer <= 0)
        {
            int attack = Random.Range(1, 4);
            if(attack == 1) dashTimer = 12f;
            else if(attack == 2) shootTimer = 7f;
            else followTimer = 10f;
        }

        transform.position = new Vector3(transform.position.x, 0f, transform.position.z);

        if(isDamageMaterial > 0)
        {
            foreach (MeshRenderer render in GetComponentsInChildren<MeshRenderer>())
            {
                render.material = damageMaterial;
            }
            isDamageMaterial -= Time.deltaTime;
        }
        else
        {
            foreach (MeshRenderer render in GetComponentsInChildren<MeshRenderer>())
            {
                render.material = standardMaterial;
            }
        }

        if(crushHealth <= 0) Death();
    }

    public void Damage(float playerDamage)
    {
        crushHealth -= playerDamage;
        isDamageMaterial = 0.05f;
        slider.value = crushHealth;
    }

    void Death()
    {
        for(int i=0; i < 1000; i++)
        {
            if(Random.value > 0.66) Instantiate(scrapPrefab, new Vector3(Random.Range(2.5f, 47.5f), 0.1f, Random.Range(2.5f, 47.5f)), 
                                    Quaternion.Euler(-90f, transform.rotation.y, transform.rotation.z));
            else if(Random.value > 0.66) Instantiate(boltPrefab, new Vector3(Random.Range(2.5f, 47.5f), 0.1f, Random.Range(2.5f, 47.5f)), 
                                    Quaternion.Euler(-90f, transform.rotation.y, transform.rotation.z));
            else Instantiate(nutPrefab, new Vector3(Random.Range(2.5f, 47.5f), 0.1f, Random.Range(2.5f, 47.5f)), 
                                    Quaternion.Euler(-90f, transform.rotation.y, transform.rotation.z));       
        }
        Destroy(gameObject);
        player.isCrushDefeated = true;
    }
}
