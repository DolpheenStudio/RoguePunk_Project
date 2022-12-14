using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float maxPlayerHealth;
    public float playerRange;
    public float playerBulletSpeed;
    public float playerAttackSpeed;
    public float currentPlayerHealth;
    public int playerScraps;
    public bool isCrushDefeated;
    public float playerDamage;
    public bool playerDoubleShot = false;
    public float playerRangeUpgrade;
    public float playerBulletSpeedUpgrade;
    public float playerAttackSpeedUpgrade;
    public float playerDamageUpgrade;
    public float playerDamageCooldown;
    public AudioSource playerDamageSound;

    public HealthBar healthBar;

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
        isCrushDefeated = playerData.isCrushDefeated;
        ReloadPlayerBonus();
    }

    void Update()
    {
        healthBar.SetMaxHealth(maxPlayerHealth);
        healthBar.SetHealth(currentPlayerHealth);

        if (currentPlayerHealth <= 0)
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
            playerDamageSound.Play(0);

        }
    }

    public void Death()
    {
        PlayerUpgrade.generatedEnemies = 0;
        PlayerUpgrade.ResetPlayerBonus();
        ReloadPlayerBonus();
        PlayerUpgrade.SetPlayerCurrentHealth(maxPlayerHealth);
        SavePlayer();
        SceneManager.LoadScene("StemEncampment", LoadSceneMode.Single);
    }

    public void ReloadPlayerBonus()
    {
        playerBulletSpeed = 10f + playerBulletSpeedUpgrade;
        for(int i=0; i<PlayerUpgrade.playerBonusBulletSpeed; i++) 
        {
            playerBulletSpeed += 2f;
        }
        
        playerAttackSpeed = 0.4f;
        for(int i=0; i<playerAttackSpeedUpgrade; i++)
        {
            playerAttackSpeed *= 0.9f;
        }
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
