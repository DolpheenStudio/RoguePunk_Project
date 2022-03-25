using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeCenter : MonoBehaviour
{
    private Player player;
    public GameObject canvas;
    public GameObject damageCanvas;
    public GameObject asCanvas;
    public GameObject rangeCanvas;
    public GameObject bsCanvas;

    public UpgradeCenterCost upgradeCenterCostDamage;
    public UpgradeCenterCost upgradeCenterCostAS;
    public UpgradeCenterCost upgradeCenterCostRange;
    public UpgradeCenterCost upgradeCenterCostBS;

    private bool isUpgradeCanvasON;
    void Start()
    {
        player = FindObjectOfType<Player>();
        canvas.SetActive(false);
        damageCanvas.SetActive(false);
        asCanvas.SetActive(false);
        rangeCanvas.SetActive(false);
        bsCanvas.SetActive(false);
        isUpgradeCanvasON = false;
    }

    void Update()
    {
        if(Vector3.Distance(transform.position, player.transform.position) <= 1.5 && !IsGamePaused.isGamePaused && !isUpgradeCanvasON)
        {
            canvas.SetActive(true);

            IsGamePaused.isUpgradeCenterOn = true;
        }
        else
        {
            canvas.SetActive(false);
            if(!isUpgradeCanvasON) IsGamePaused.isUpgradeCenterOn = false;
        }
        if(Vector3.Distance(transform.position, player.transform.position) >= 1.5)
        {
            damageCanvas.SetActive(false);
            asCanvas.SetActive(false);
            rangeCanvas.SetActive(false);
            bsCanvas.SetActive(false);
            isUpgradeCanvasON = false;
        }
    }

    public void DamageButton()
    {
        canvas.SetActive(false);
        damageCanvas.SetActive(true);
        isUpgradeCanvasON = true;
        upgradeCenterCostDamage.ReloadUpgradeCost(0);

    }
    public void ASButton()
    {
        canvas.SetActive(false);
        asCanvas.SetActive(true);
        isUpgradeCanvasON = true;
        upgradeCenterCostAS.ReloadUpgradeCost(1);
    }
    public void RangeButton()
    {
        canvas.SetActive(false);
        rangeCanvas.SetActive(true);
        isUpgradeCanvasON = true;
        upgradeCenterCostRange.ReloadUpgradeCost(2);
    }
    public void BSButton()
    {
        canvas.SetActive(false);
        bsCanvas.SetActive(true);
        isUpgradeCanvasON = true;
        upgradeCenterCostBS.ReloadUpgradeCost(3);
    }

    public void ReturnButton()
    {
        damageCanvas.SetActive(false);
        asCanvas.SetActive(false);
        rangeCanvas.SetActive(false);
        bsCanvas.SetActive(false);
        isUpgradeCanvasON = false;
    }
}
