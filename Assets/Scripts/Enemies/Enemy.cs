using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float maxEnemyHealth = 50;
    public float currentEnemyHealth;
    public Material standardMaterial;
    public Material damageMaterial;

    private float isDamageMaterial = 0f;

    void Start()
    {
        currentEnemyHealth = maxEnemyHealth;
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
        isDamageMaterial = 0.1f;
    }

    void Death()
    {
        Destroy(gameObject);
    }
}
