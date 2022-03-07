using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float maxEnemyHealth = 50;
    public float currentEnemyHealth;
    public float enemyDamage;
    public float enemyAttackSpeed;
    public Material standardMaterial;
    public Material damageMaterial;

    private Player player;
    private float isDamageMaterial = 0f;

    void Start()
    {
        player = FindObjectOfType<Player>();
        currentEnemyHealth = maxEnemyHealth;
        if(Vector3.Distance(transform.position, player.transform.position) <= 30)
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
        currentEnemyHealth -= playerDamage;
        isDamageMaterial = 0.05f;
    }

    void Death()
    {
        Destroy(gameObject);
    }
}
