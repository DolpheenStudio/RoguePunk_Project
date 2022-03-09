using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerUpgradeData
{
    public float playerDamageUpgrade;
    public float playerRangeUpgrade;
    public float playerAttackSpeedUpgrade;
    public float playerBulletSpeedUpgrade;
    public int playerScraps;

    public PlayerUpgradeData (Player player)
    {
        playerDamageUpgrade = player.playerDamageUpgrade;
        playerRangeUpgrade = player.playerRangeUpgrade;
        playerAttackSpeedUpgrade = player.playerAttackSpeedUpgrade;
        playerBulletSpeedUpgrade = player.playerBulletSpeedUpgrade;
        playerScraps = player.playerScraps;
    }
}
