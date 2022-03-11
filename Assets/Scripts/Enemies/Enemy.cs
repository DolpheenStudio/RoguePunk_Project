using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float maxEnemyHealth = 50;
    public float currentEnemyHealth;
    public Material standardMaterial;
    public Material damageMaterial;
    public GameObject scrapPrefab;

    private Player player;
    private EndTeleport endTeleport;
    private float isDamageMaterial = 0f;

    void Start()
    {
        player = FindObjectOfType<Player>();
        endTeleport = FindObjectOfType<EndTeleport>();

        currentEnemyHealth = maxEnemyHealth;
        if(Vector3.Distance(transform.position, player.transform.position) <= 200 || Vector3.Distance(transform.position, endTeleport.transform.position) <=3)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if(currentEnemyHealth <= 0)
        {
            Death();
        }
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
    }

    public void Damage(float playerDamage)
    {
        if(player.playerDamageCooldown <= 0)
        {
            currentEnemyHealth -= playerDamage;
            isDamageMaterial = 0.05f;
        }
    }

    void Death()
    {
        Destroy(gameObject);
        for(int i=0; i<Random.Range(10,15); i++)
        {
            Instantiate(scrapPrefab, new Vector3(transform.position.x + Random.Range(-1f, 1f), 0.08f, transform.position.z + Random.Range(-1f, 1f)), 
            Quaternion.Euler(-90f, transform.rotation.y, transform.rotation.z));
        }
    }
}
