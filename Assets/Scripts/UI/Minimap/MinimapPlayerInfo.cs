using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MinimapPlayerInfo : MonoBehaviour
{
    public Player player;
    public Text text;
    private bool isPlayerLoaded = false;

    void LateUpdate()
    {
        if(!isPlayerLoaded) 
        {
            player = FindObjectOfType<Player>();
            isPlayerLoaded = true;
        }
        text.text = "Level: " + PlayerUpgrade.playerLevelIteration +
        "\nDamage: " + player.playerDamage + 
        "\nAttack Speed: " + player.playerAttackSpeed + " per second" +
        "\nRange: " + player.playerRange + 
        "\nBulletSpeed: " + player.playerBulletSpeed;
    }
}
