using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxPlayerHealth = 100f;
    public float playerRange = 5f;
    public float playerBulletSpeed = 15f;
    public float playerAttackSpeed = 1f;
    public float currentPlayerHealth = 0f;
    public float playerDamage = 10;
    public bool playerDoubleShot = false;
    public bool playerLevelReload = true;

    private EndTeleport endTeleport;

    void Start()
    {
        endTeleport = FindObjectOfType<EndTeleport>();
        currentPlayerHealth = maxPlayerHealth;
    }

    void Update()
    {
        if(currentPlayerHealth <= 0)
        {
            Death();
        }
        if(Input.GetKey(KeyCode.R))
        {
            endTeleport.Portal();
        }
    }

    public void PlayerDamage(float damage)
    {
        currentPlayerHealth -= damage;

    }

    void Death()
    {
        currentPlayerHealth = maxPlayerHealth;
        Debug.Log("PLAYER IS DEAD");
    }
}
