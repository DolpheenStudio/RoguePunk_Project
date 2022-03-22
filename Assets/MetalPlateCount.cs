using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MetalPlateCount : MonoBehaviour
{
    private Text text;
    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        if(gameObject.name == "CommonItemCount") text.text = "" + PlayerInventory.metalPlate[0];
        if(gameObject.name == "UncommonItemCount") text.text = "" + PlayerInventory.metalPlate[1];
        if(gameObject.name == "RareItemCount") text.text = "" + PlayerInventory.metalPlate[2];
        if(gameObject.name == "EpicItemCount") text.text = "" + PlayerInventory.metalPlate[3];
        if(gameObject.name == "LegendaryItemCount") text.text = "" + PlayerInventory.metalPlate[4];
    }
}
