using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGameButton : MonoBehaviour
{
    private Player player;
    public GameObject saveInfo;
    void Start()
    {
        saveInfo.SetActive(false);
        player = FindObjectOfType<Player>();
    }

    public void SaveGame() 
    {
        player.SavePlayer();
        StartCoroutine(ShowSaveInfo());
    }

    public void Restart()
    {
        PlayerInventory.ResetItems();
        PlayerUpgrade.isCrushDefeated = false;
        player.isCrushDefeated = false;
        player.playerScraps = 0;
        player.playerAttackSpeedUpgrade = 0;
        player.playerBulletSpeedUpgrade = 0;
        player.playerDamageUpgrade = 0;
        player.playerRangeUpgrade = 0;
        player.Death();
    }

    IEnumerator ShowSaveInfo()
    {
        saveInfo.SetActive(true);
        yield return new WaitForSeconds(2f);
        saveInfo.SetActive(false);
    }
}
