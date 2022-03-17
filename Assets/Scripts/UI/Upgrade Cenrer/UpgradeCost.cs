using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeCost : MonoBehaviour
{
    private Player player;
    private Text text;
    void Start()
    {
        player = FindObjectOfType<Player>();
        text = GetComponent<Text>();
    }

    void Update()
    {
        if(gameObject.name == "DamageCost")
        {
            text.text = "" + (1000 + 100 * player.playerDamageUpgrade);
        }
        if(gameObject.name == "ASCost")
        {
            text.text = "" + (1000 + 100 * player.playerAttackSpeedUpgrade);
        }
        if(gameObject.name == "RangeCost")
        {
            text.text = "" + (1000 + 100 * player.playerRangeUpgrade);
        }
        if(gameObject.name == "BSCost")
        {
            text.text = "" + (1000 + 100 * player.playerBulletSpeedUpgrade);
        }
    }
}
