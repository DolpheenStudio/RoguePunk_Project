using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    Text text;
    Player player;
    void Start()
    {
        text = GetComponentInChildren<Text>();
        player = FindObjectOfType<Player>();
    }
    void Update()
    {
        if(gameObject.name == "DamageButton")
        text.text = "DAMAGE + " + player.playerDamageUpgrade;
        if(gameObject.name == "ASButton")
        text.text = "ATTACK SPEED + " + player.playerAttackSpeedUpgrade;
        if(gameObject.name == "RangeButton")
        text.text = "RANGE + " + player.playerRangeUpgrade;
        if(gameObject.name == "BSButton")
        text.text = "BULLET SPEED + " + player.playerBulletSpeedUpgrade;
    }
    public void UpgradeDamage()
    {
        if(player.playerScraps >= 1000 + 100 * player.playerDamageUpgrade) 
        {
            player.playerScraps -= 1000 + 100 * (int) player.playerDamageUpgrade;
            player.playerDamageUpgrade++;
            SavePlayerSystem.SavePlayer(player);
            player.ReloadPlayerBonus();
        }
    }
    public void UpgradeAttackSpeed()
    {
        if(player.playerScraps >= 1000 + 100 * player.playerAttackSpeedUpgrade) 
        {
            player.playerScraps -= 1000 + 100 * (int) player.playerAttackSpeedUpgrade;
            player.playerAttackSpeedUpgrade++;
            SavePlayerSystem.SavePlayer(player);
            player.ReloadPlayerBonus();
        }
    }
    public void UpgradeRange()
    {
        if(player.playerScraps >= 1000 + 100 * player.playerRangeUpgrade) 
        {
            player.playerScraps -= 1000 + 100 * (int) player.playerRangeUpgrade;
            player.playerRangeUpgrade++;
            SavePlayerSystem.SavePlayer(player);
            player.ReloadPlayerBonus();
        }
    }
    public void UpgradeBulletSpeed()
    {
        if(player.playerScraps >= 1000 + 100 * player.playerBulletSpeedUpgrade) 
        {
            player.playerScraps -= 1000 + 100 * (int) player.playerBulletSpeedUpgrade;
            player.playerBulletSpeedUpgrade++;
            SavePlayerSystem.SavePlayer(player);
            player.ReloadPlayerBonus();
        }
    }
}
