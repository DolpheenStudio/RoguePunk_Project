using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemAmount : MonoBehaviour
{
    public Text text;
    void Start()
    {
        gameObject.SetActive(false);
        text = GetComponentInChildren<Text>();
    }


    void Update()
    {
        
        //if(Input.GetButtonDown("Use") && gameObject.activeSelf) gameObject.SetActive(false);
        /*if(Input.GetButtonDown("Inventory"))
        {
            gameObject.SetActive(true);
            text.text = "Common Gunpowder " + PlayerUpgrade.commonGunpowder + 
                        "\nUncommon Gunpowder " + PlayerUpgrade.uncommonGunpowder +
                        "\nRare Gunpowder " + PlayerUpgrade.rareGunpowder +
                        "\nCommon Metal Plate " + PlayerUpgrade.commonMetalPlate +
                        "\nUncommon Metal Plate " + PlayerUpgrade.uncommonMetalPlate +
                        "\nRare Gunpowder " + PlayerUpgrade.rareGunpowder +
                        "\nCommon Bearing " + PlayerUpgrade.commonBearing +
                        "\nUncommon Bearing " + PlayerUpgrade.uncommonBearing +
                        "\nRare Bearing " + PlayerUpgrade.rareBearing;
        }*/
    }
}
