using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeButton : MonoBehaviour
{
    public UpgradeCenterCost upgradeCenterCost;
    private Player player;

    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    public void UpgradeDamage()
    {
        if(player.playerDamageUpgrade == 0)
        {
            if(player.playerScraps >= 1200 && PlayerInventory.gunPowder[0] >=5 && PlayerInventory.metalPlate[0] >=5 && PlayerInventory.bearing[0] >=5)
            {
                player.playerScraps -= 1200;
                PlayerInventory.gunPowder[0] -=5;
                PlayerInventory.metalPlate[0] -=5;
                PlayerInventory.bearing[0] -=5;
                player.playerDamageUpgrade++;
                upgradeCenterCost.ReloadUpgradeCost(0);

            }
        }
        else if(player.playerDamageUpgrade == 1)
        {
            if(player.playerScraps >= 1400 && PlayerInventory.gunPowder[0] >=10 && PlayerInventory.metalPlate[0] >=10 && PlayerInventory.bearing[0] >=10)
            {
                player.playerScraps -= 1400;
                PlayerInventory.gunPowder[0] -=10;
                PlayerInventory.metalPlate[0] -=10;
                PlayerInventory.bearing[0] -=10;
                player.playerDamageUpgrade++;
                upgradeCenterCost.ReloadUpgradeCost(0);
            }
        }
        else if(player.playerDamageUpgrade == 2)
        {
            if(player.playerScraps >= 1600 && PlayerInventory.gunPowder[1] >=2 && PlayerInventory.metalPlate[0] >=2 && PlayerInventory.bearing[0] >=2)
            {
                player.playerScraps -= 1600;
                PlayerInventory.gunPowder[1] -=2;
                PlayerInventory.metalPlate[1] -=2;
                PlayerInventory.bearing[1] -=2;
                player.playerDamageUpgrade++;
                upgradeCenterCost.ReloadUpgradeCost(0);
            }
        }
        else if(player.playerDamageUpgrade == 3)
        {
            if(player.playerScraps >= 1800 && PlayerInventory.gunPowder[1] >=5 && PlayerInventory.metalPlate[1] >=5 && PlayerInventory.bearing[1] >=5)
            {
                player.playerScraps -= 1800;
                PlayerInventory.gunPowder[1] -=5;
                PlayerInventory.metalPlate[1] -=5;
                PlayerInventory.bearing[1] -=5;
                player.playerDamageUpgrade++;
                upgradeCenterCost.ReloadUpgradeCost(0);
            }
        }
        else if(player.playerDamageUpgrade == 4)
        {
            if(player.playerScraps >= 2000 && PlayerInventory.gunPowder[2] >=3 && PlayerInventory.metalPlate[2] >=3 && PlayerInventory.bearing[2] >=3)
            {
                player.playerScraps -= 2000;
                PlayerInventory.gunPowder[2] -=3;
                PlayerInventory.metalPlate[2] -=3;
                PlayerInventory.bearing[2] -=3;
                player.playerDamageUpgrade++;
                upgradeCenterCost.ReloadUpgradeCost(0);
            }
        }
    }
    public void UpgradeAttackSpeed()
    {
        if(player.playerAttackSpeedUpgrade == 0)
        {
            if(player.playerScraps >= 1200 && PlayerInventory.gunPowder[0] >=5 && PlayerInventory.metalPlate[0] >=5 && PlayerInventory.bearing[0] >=5)
            {
                player.playerScraps -= 1200;
                PlayerInventory.gunPowder[0] -=5;
                PlayerInventory.metalPlate[0] -=5;
                PlayerInventory.bearing[0] -=5;
                player.playerAttackSpeedUpgrade++;
                upgradeCenterCost.ReloadUpgradeCost(1);

            }
        }
        else if(player.playerAttackSpeedUpgrade == 1)
        {
            if(player.playerScraps >= 1400 && PlayerInventory.gunPowder[0] >=10 && PlayerInventory.metalPlate[0] >=10 && PlayerInventory.bearing[0] >=10)
            {
                player.playerScraps -= 1400;
                PlayerInventory.gunPowder[0] -=10;
                PlayerInventory.metalPlate[0] -=10;
                PlayerInventory.bearing[0] -=10;
                player.playerAttackSpeedUpgrade++;
                upgradeCenterCost.ReloadUpgradeCost(1);
            }
        }
        else if(player.playerAttackSpeedUpgrade == 2)
        {
            if(player.playerScraps >= 1600 && PlayerInventory.gunPowder[1] >=2 && PlayerInventory.metalPlate[0] >=2 && PlayerInventory.bearing[0] >=2)
            {
                player.playerScraps -= 1600;
                PlayerInventory.gunPowder[1] -=2;
                PlayerInventory.metalPlate[1] -=2;
                PlayerInventory.bearing[1] -=2;
                player.playerAttackSpeedUpgrade++;
                upgradeCenterCost.ReloadUpgradeCost(1);
            }
        }
        else if(player.playerAttackSpeedUpgrade == 3)
        {
            if(player.playerScraps >= 1800 && PlayerInventory.gunPowder[1] >=5 && PlayerInventory.metalPlate[1] >=5 && PlayerInventory.bearing[1] >=5)
            {
                player.playerScraps -= 1800;
                PlayerInventory.gunPowder[1] -=5;
                PlayerInventory.metalPlate[1] -=5;
                PlayerInventory.bearing[1] -=5;
                player.playerAttackSpeedUpgrade++;
                upgradeCenterCost.ReloadUpgradeCost(1);
            }
        }
        else if(player.playerAttackSpeedUpgrade == 4)
        {
            if(player.playerScraps >= 2000 && PlayerInventory.gunPowder[2] >=3 && PlayerInventory.metalPlate[2] >=3 && PlayerInventory.bearing[2] >=3)
            {
                player.playerScraps -= 2000;
                PlayerInventory.gunPowder[2] -=3;
                PlayerInventory.metalPlate[2] -=3;
                PlayerInventory.bearing[2] -=3;
                player.playerAttackSpeedUpgrade++;
                upgradeCenterCost.ReloadUpgradeCost(1);
            }
        }
    }
    public void UpgradeRange()
    {
        if(player.playerRangeUpgrade == 0)
        {
            if(player.playerScraps >= 1200 && PlayerInventory.gunPowder[0] >=5 && PlayerInventory.metalPlate[0] >=5 && PlayerInventory.bearing[0] >=5)
            {
                player.playerScraps -= 1200;
                PlayerInventory.gunPowder[0] -=5;
                PlayerInventory.metalPlate[0] -=5;
                PlayerInventory.bearing[0] -=5;
                player.playerRangeUpgrade++;
                upgradeCenterCost.ReloadUpgradeCost(2);

            }
        }
        else if(player.playerRangeUpgrade == 1)
        {
            if(player.playerScraps >= 1400 && PlayerInventory.gunPowder[0] >=10 && PlayerInventory.metalPlate[0] >=10 && PlayerInventory.bearing[0] >=10)
            {
                player.playerScraps -= 1400;
                PlayerInventory.gunPowder[0] -=10;
                PlayerInventory.metalPlate[0] -=10;
                PlayerInventory.bearing[0] -=10;
                player.playerRangeUpgrade++;
                upgradeCenterCost.ReloadUpgradeCost(2);
            }
        }
        else if(player.playerRangeUpgrade == 2)
        {
            if(player.playerScraps >= 1600 && PlayerInventory.gunPowder[1] >=2 && PlayerInventory.metalPlate[0] >=2 && PlayerInventory.bearing[0] >=2)
            {
                player.playerScraps -= 1600;
                PlayerInventory.gunPowder[1] -=2;
                PlayerInventory.metalPlate[1] -=2;
                PlayerInventory.bearing[1] -=2;
                player.playerRangeUpgrade++;
                upgradeCenterCost.ReloadUpgradeCost(2);
            }
        }
        else if(player.playerRangeUpgrade == 3)
        {
            if(player.playerScraps >= 1800 && PlayerInventory.gunPowder[1] >=5 && PlayerInventory.metalPlate[1] >=5 && PlayerInventory.bearing[1] >=5)
            {
                player.playerScraps -= 1800;
                PlayerInventory.gunPowder[1] -=5;
                PlayerInventory.metalPlate[1] -=5;
                PlayerInventory.bearing[1] -=5;
                player.playerRangeUpgrade++;
                upgradeCenterCost.ReloadUpgradeCost(2);
            }
        }
        else if(player.playerRangeUpgrade == 4)
        {
            if(player.playerScraps >= 2000 && PlayerInventory.gunPowder[2] >=3 && PlayerInventory.metalPlate[2] >=3 && PlayerInventory.bearing[2] >=3)
            {
                player.playerScraps -= 2000;
                PlayerInventory.gunPowder[2] -=3;
                PlayerInventory.metalPlate[2] -=3;
                PlayerInventory.bearing[2] -=3;
                player.playerRangeUpgrade++;
                upgradeCenterCost.ReloadUpgradeCost(2);
            }
        }
    }
    public void UpgradeBulletSpeed()
    {
        if(player.playerBulletSpeedUpgrade == 0)
        {
            if(player.playerScraps >= 1200 && PlayerInventory.gunPowder[0] >=5 && PlayerInventory.metalPlate[0] >=5 && PlayerInventory.bearing[0] >=5)
            {
                player.playerScraps -= 1200;
                PlayerInventory.gunPowder[0] -=5;
                PlayerInventory.metalPlate[0] -=5;
                PlayerInventory.bearing[0] -=5;
                player.playerBulletSpeedUpgrade++;
                upgradeCenterCost.ReloadUpgradeCost(3);

            }
        }
        else if(player.playerBulletSpeedUpgrade == 1)
        {
            if(player.playerScraps >= 1400 && PlayerInventory.gunPowder[0] >=10 && PlayerInventory.metalPlate[0] >=10 && PlayerInventory.bearing[0] >=10)
            {
                player.playerScraps -= 1400;
                PlayerInventory.gunPowder[0] -=10;
                PlayerInventory.metalPlate[0] -=10;
                PlayerInventory.bearing[0] -=10;
                player.playerBulletSpeedUpgrade++;
                upgradeCenterCost.ReloadUpgradeCost(3);
            }
        }
        else if(player.playerBulletSpeedUpgrade == 2)
        {
            if(player.playerScraps >= 1600 && PlayerInventory.gunPowder[1] >=2 && PlayerInventory.metalPlate[0] >=2 && PlayerInventory.bearing[0] >=2)
            {
                player.playerScraps -= 1600;
                PlayerInventory.gunPowder[1] -=2;
                PlayerInventory.metalPlate[1] -=2;
                PlayerInventory.bearing[1] -=2;
                player.playerBulletSpeedUpgrade++;
                upgradeCenterCost.ReloadUpgradeCost(3);
            }
        }
        else if(player.playerBulletSpeedUpgrade == 3)
        {
            if(player.playerScraps >= 1800 && PlayerInventory.gunPowder[1] >=5 && PlayerInventory.metalPlate[1] >=5 && PlayerInventory.bearing[1] >=5)
            {
                player.playerScraps -= 1800;
                PlayerInventory.gunPowder[1] -=5;
                PlayerInventory.metalPlate[1] -=5;
                PlayerInventory.bearing[1] -=5;
                player.playerBulletSpeedUpgrade++;
                upgradeCenterCost.ReloadUpgradeCost(3);
            }
        }
        else if(player.playerBulletSpeedUpgrade == 4)
        {
            if(player.playerScraps >= 2000 && PlayerInventory.gunPowder[2] >=3 && PlayerInventory.metalPlate[2] >=3 && PlayerInventory.bearing[2] >=3)
            {
                player.playerScraps -= 2000;
                PlayerInventory.gunPowder[2] -=3;
                PlayerInventory.metalPlate[2] -=3;
                PlayerInventory.bearing[2] -=3;
                player.playerBulletSpeedUpgrade++;
                upgradeCenterCost.ReloadUpgradeCost(3);
            }
        }
    }
}
