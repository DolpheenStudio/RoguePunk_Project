using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeCenterCost : MonoBehaviour
{
    public GameObject image1;
    public GameObject image2;
    public GameObject image3;

    public Text text;

    private Player player;

    Color white;
    Color green;
    Color blue;

    public void ReloadUpgradeCost (int stat)
    {
        player = FindObjectOfType<Player>();
        white = new Color32(255, 255, 255, 255);
        green = new Color32(46, 253, 77, 255);
        blue = new Color32(28, 125, 255, 255);

        int upgradeLevel = 0;
        if(stat == 0) upgradeLevel = (int) player.playerDamageUpgrade;
        if(stat == 1) upgradeLevel = (int) player.playerAttackSpeedUpgrade;
        if(stat == 2) upgradeLevel = (int) player.playerRangeUpgrade;
        if(stat == 3) upgradeLevel = (int) player.playerBulletSpeedUpgrade;

        if(upgradeLevel == 0)
        {
            image1.GetComponent<Image>().color = white;
            image2.GetComponent<Image>().color = white;
            image3.GetComponent<Image>().color = white;

            text.text = "SCRAPS\n1200";

            image1.GetComponentInChildren<Text>().text = "" + 5;
            image2.GetComponentInChildren<Text>().text = "" + 5;
            image3.GetComponentInChildren<Text>().text = "" + 5;
        }
        if(upgradeLevel == 1)
        {
            image1.GetComponent<Image>().color = white;
            image2.GetComponent<Image>().color = white;
            image3.GetComponent<Image>().color = white;

            text.text = "SCRAPS\n1400";

            image1.GetComponentInChildren<Text>().text = "" + 10;
            image2.GetComponentInChildren<Text>().text = "" + 10;
            image3.GetComponentInChildren<Text>().text = "" + 10;
        }
        if(upgradeLevel == 2)
        {
            image1.GetComponent<Image>().color = green;
            image2.GetComponent<Image>().color = green;
            image3.GetComponent<Image>().color = green;

            text.text = "SCRAPS\n1600";

            image1.GetComponentInChildren<Text>().text = "" + 2;
            image2.GetComponentInChildren<Text>().text = "" + 2;
            image3.GetComponentInChildren<Text>().text = "" + 2;
        }
        if(upgradeLevel == 3)
        {
            image1.GetComponent<Image>().color = green;
            image2.GetComponent<Image>().color = green;
            image3.GetComponent<Image>().color = green;

            text.text = "SCRAPS\n1800";

            image1.GetComponentInChildren<Text>().text = "" + 5;
            image2.GetComponentInChildren<Text>().text = "" + 5;
            image3.GetComponentInChildren<Text>().text = "" + 5;
        }
        if(upgradeLevel == 4)
        {
            image1.GetComponent<Image>().color = blue;
            image2.GetComponent<Image>().color = blue;
            image3.GetComponent<Image>().color = blue;

            text.text = "SCRAPS\n2000";

            image1.GetComponentInChildren<Text>().text = "" + 3;
            image2.GetComponentInChildren<Text>().text = "" + 3;
            image3.GetComponentInChildren<Text>().text = "" + 3;
        }
    }
}
