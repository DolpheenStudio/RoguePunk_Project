using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxPlayerHealth;
    public float playerRange;
    public float playerBulletSpeed;
    public float playerAttackSpeed;
    public float currentPlayerHealth;
    public float playerDamage;
    public bool playerDoubleShot = false;
    public bool playerLevelReload = true;
    public float maxPlayerHealthBase = 100f;
    public float playerRangeBase = 5f;
    public float playerBulletSpeedBase = 100f;
    public float playerAttackSpeedBase = 1f;
    public float playerDamageBase = 10;
    public float playerDamageCooldown = 0f;
    private EndTeleport endTeleport;

    void Start()
    {
        endTeleport = FindObjectOfType<EndTeleport>();
        currentPlayerHealth = PlayerUpgrade.currentPlayerHealthStatic;

        ReloadPlayerBonus();
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
        if(playerDamageCooldown >= 0)playerDamageCooldown -= Time.deltaTime;
    }

    public void PlayerDamage(float damage)
    {
        if(playerDamageCooldown <= 0) 
        {
            currentPlayerHealth -= damage;
            playerDamageCooldown = 0.3f;
        }
    }

    void Death()
    {
        PlayerUpgrade.ResetPlayerBunus();
        ReloadPlayerBonus();
        currentPlayerHealth = maxPlayerHealth;
        Debug.Log("PLAYER IS DEAD");
    }

    public void ReloadPlayerBonus()
    {
        maxPlayerHealth = maxPlayerHealthBase + PlayerUpgrade.playerBonusHealth;
        playerRange = playerRangeBase + PlayerUpgrade.playerBonusRange;
        
        
        playerBulletSpeed = playerBulletSpeedBase;
        for(int i=0; i<PlayerUpgrade.playerBonusBulletSpeed; i++) 
        {
            playerBulletSpeed *= 1.2f;
        }
        
        playerAttackSpeed = playerAttackSpeedBase;
        for(int i=0; i<PlayerUpgrade.playerBonusAttackSpeed; i++) 
        {
            playerAttackSpeed *= 0.8f;
        }

        playerDamage = playerDamageBase;
        for(int i=0; i<PlayerUpgrade.playerBonusDamage; i++) 
        {
            playerDamage *= 1.2f;
        } 

        playerDoubleShot = PlayerUpgrade.playerDoubleShot;

        maxPlayerHealth = maxPlayerHealthBase;
        for(int i=0; i<PlayerUpgrade.playerBonusEmptyHealth; i++) 
        {
            maxPlayerHealth += 40;
        }

        for(int i=0; i<PlayerUpgrade.playerBonusHealth; i++) 
        {
            maxPlayerHealth += 20;
        }

        playerRange = playerRangeBase;
        for(int i=0; i<PlayerUpgrade.playerBonusRange; i++) 
        {
            playerRange *= 1.25f;
        }
    }
}
