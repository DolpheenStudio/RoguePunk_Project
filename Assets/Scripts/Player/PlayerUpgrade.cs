using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerUpgrade
{
    public static float playerBonusDamage {get; set;}
    public static float playerBonusAttackSpeed {get; set;}
    public static float playerBonusBulletSpeed {get; set;}
    public static float playerBonusHealth {get; set;}
    public static float playerBonusEmptyHealth {get; set;}
    public static float playerBonusRange {get; set;}
    public static bool playerDoubleShot {get; set;}
    public static float currentPlayerHealthStatic {get; set;} = 100f;
    public static int playerLevelIteration {get; set;}

    public static void SetPlayerCurrentHealth(float currentPlayerHealth) 
    {
        currentPlayerHealthStatic = currentPlayerHealth;
    }
    public static void ResetPlayerBunus() 
    {
        playerBonusDamage = 0;
        playerBonusAttackSpeed = 0;
        playerBonusBulletSpeed = 0;
        playerBonusHealth = 0;
        playerBonusEmptyHealth = 0;
        playerBonusRange = 0;
        playerDoubleShot = false;
        playerLevelIteration = 0;
    }
}
