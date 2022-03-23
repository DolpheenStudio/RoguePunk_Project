using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeLevel : MonoBehaviour
{
    private Text text;
    private Player player;
    void Start()
    {
        text = GetComponent<Text>();
        player = FindObjectOfType<Player>();
    }

    
    void Update()
    {
        if(transform.parent.name == "DamageUpgrade")
        {
            if(gameObject.name == "CurrentLevelNumber") text.text = "" + player.playerDamageUpgrade;
            else if(gameObject.name == "NextLevelNumber") text.text = "" + (player.playerDamageUpgrade + 1);
        }
        if(transform.parent.name == "ASUpgrade")
        {
            if(gameObject.name == "CurrentLevelNumber") text.text = "" + player.playerAttackSpeedUpgrade;
            else if(gameObject.name == "NextLevelNumber") text.text = "" + (player.playerAttackSpeedUpgrade + 1);
        }
        if(transform.parent.name == "RangeUpgrade")
        {
            if(gameObject.name == "CurrentLevelNumber") text.text = "" + player.playerRangeUpgrade;
            else if(gameObject.name == "NextLevelNumber") text.text = "" + (player.playerRangeUpgrade + 1);
        }
        if(transform.parent.name == "BSUpgrade")
        {
            if(gameObject.name == "CurrentLevelNumber") text.text = "" + player.playerBulletSpeedUpgrade;
            else if(gameObject.name == "NextLevelNumber") text.text = "" + (player.playerBulletSpeedUpgrade + 1);
        }
    }
}
