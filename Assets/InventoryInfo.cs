using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryInfo : MonoBehaviour
{
    private Text text;
    void Start()
    {
        text = GetComponent<Text>();
    }


    void Update()
    {
        if(gameObject.name == "GunPowderInfo")
            text.text = "Common Gunpowder " + PlayerInventory.gunPowder[0] + 
                        "\n\nUncommon Gunpowder " + PlayerInventory.gunPowder[1] +
                        "\n\nRare Gunpowder " + PlayerInventory.gunPowder[2] + 
                        "\n\nEpic Gunpowder " + PlayerInventory.gunPowder[3] + 
                        "\n\nLegendary Gunpowder " + PlayerInventory.gunPowder[4];
        if(gameObject.name == "MetalPlateInfo")
            text.text = "Common Metal Plate " + PlayerInventory.metalPlate[0] + 
                        "\n\nUncommon Metal Plate " + PlayerInventory.metalPlate[1] +
                        "\n\nRare Metal Plate " + PlayerInventory.metalPlate[2] + 
                        "\n\nEpic Metal Plate " + PlayerInventory.metalPlate[3] + 
                        "\n\nLegendary Metal Plate " + PlayerInventory.metalPlate[4];
        if(gameObject.name == "BearingInfo")
            text.text = "Common Bearing " + PlayerInventory.bearing[0] + 
                        "\n\nUncommon Bearing " + PlayerInventory.bearing[1] +
                        "\n\nRare Bearing " + PlayerInventory.bearing[2] + 
                        "\n\nEpic Bearing " + PlayerInventory.bearing[3] + 
                        "\n\nLegendary Bearing " + PlayerInventory.bearing[4];
    }
}
