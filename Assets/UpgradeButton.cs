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
}
