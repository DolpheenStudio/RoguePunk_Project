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
    public int playerScraps;
    public float playerDamage;
    public bool playerDoubleShot = false;
    public float playerRangeUpgrade;
    public float playerBulletSpeedUpgrade;
    public float playerAttackSpeedUpgrade;
    public float playerDamageUpgrade;
    public float playerDamageCooldown;

    public GameObject healthBar;

    void Start()
    {
        healthBar = FindObjectOfType<HealthBar>();
        currentPlayerHealth = PlayerUpgrade.currentPlayerHealthStatic;
        healthBar.SetMaxHealth(maxPlayerHealth);
        playerRangeUpgrade = 0f;
        playerBulletSpeedUpgrade = 0f;
        playerDamageUpgrade = 0f;
        playerAttackSpeedUpgrade = 0f;
        LoadPlayer();
    }

    public void SavePlayer() 
    {
        SavePlayerSystem.SavePlayer(this);
    }

    public void LoadPlayer() 
    {
        PlayerUpgradeData playerData = SavePlayerSystem.LoadPlayer();
        playerAttackSpeedUpgrade = playerData.playerAttackSpeedUpgrade;
        playerDamageUpgrade = playerData.playerDamageUpgrade;
        playerBulletSpeedUpgrade = playerData.playerBulletSpeedUpgrade;
        playerRangeUpgrade = playerData.playerRangeUpgrade;
        playerScraps = playerData.playerScraps;
        ReloadPlayerBonus();
    }

    void Update()
    {
        if(currentPlayerHealth <= 0)
        {
            Death();
        }
        if(playerDamageCooldown >= 0) playerDamageCooldown -= Time.deltaTime;
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
        playerBulletSpeed = 10f + playerBulletSpeedUpgrade;
        for(int i=0; i<PlayerUpgrade.playerBonusBulletSpeed; i++) 
        {
            playerBulletSpeed += 2f;
        }
        
        playerAttackSpeed = 1f + playerAttackSpeedUpgrade;
        for(int i=0; i<PlayerUpgrade.playerBonusAttackSpeed; i++) 
        {
            playerAttackSpeed *= 0.8f;
        }

        playerDamage = 10f + playerDamageUpgrade;
        for(int i=0; i<PlayerUpgrade.playerBonusDamage; i++) 
        {
            playerDamage += 2f;
        } 

        playerDoubleShot = PlayerUpgrade.playerDoubleShot;

        maxPlayerHealth = 100f;
        for(int i=0; i<PlayerUpgrade.playerBonusEmptyHealth; i++) 
        {
            maxPlayerHealth += 40;
        }

        for(int i=0; i<PlayerUpgrade.playerBonusHealth; i++) 
        {
            maxPlayerHealth += 20;
        }

        playerRange = 5f + playerRangeUpgrade;
        for(int i=0; i<PlayerUpgrade.playerBonusRange; i++) 
        {
            playerRange += 1f;
        }
    }
}
