using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float maxEnemyHealth = 50;
    public float currentEnemyHealth = 1;
    public Material standardMaterial;
    public Material damageMaterial;
    public GameObject scrapPrefab;
    public GameObject nutPrefab;
    public GameObject boltPrefab;

    private Player player;
    private EndTeleport endTeleport;
    private float isDamageMaterial = 0f;

    void Start()
    {
        player = FindObjectOfType<Player>();
        endTeleport = FindObjectOfType<EndTeleport>();

        maxEnemyHealth += maxEnemyHealth * (PlayerUpgrade.playerLevelIteration - 1) * 0.1f;
        currentEnemyHealth = maxEnemyHealth;
        /*if(Vector3.Distance(transform.position, player.transform.position) <= 20 || Vector3.Distance(transform.position, endTeleport.transform.position) <=3)
        {
            Destroy(gameObject);
            PlayerUpgrade.generatedEnemies--;
        }*/    
    }

    void Update()
    {
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

    void LateUpdate()
    {
        if(currentEnemyHealth <= 0)
        {
            Death();
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
        for(int i=0; i<(int) (Random.Range(10,15) + Random.Range(10, 15) * (PlayerUpgrade.playerLevelIteration - 1) * 0.1f); i++)
        {
            if(Random.value > 0.66) Instantiate(scrapPrefab, new Vector3(transform.position.x + Random.Range(-1f, 1f), 0.08f, transform.position.z + Random.Range(-1f, 1f)), 
                                    Quaternion.Euler(-90f, transform.rotation.y, transform.rotation.z));
            else if(Random.value > 0.66) Instantiate(boltPrefab, new Vector3(transform.position.x + Random.Range(-1f, 1f), 0.08f, transform.position.z + Random.Range(-1f, 1f)), 
                                    Quaternion.Euler(0f, transform.rotation.y, transform.rotation.z));
            else Instantiate(nutPrefab, new Vector3(transform.position.x + Random.Range(-1f, 1f), 0.08f, transform.position.z + Random.Range(-1f, 1f)), 
                                    Quaternion.Euler(-90f, transform.rotation.y, transform.rotation.z));          
        }
        PlayerUpgrade.generatedEnemies--;
        Destroy(gameObject);
    }
}
