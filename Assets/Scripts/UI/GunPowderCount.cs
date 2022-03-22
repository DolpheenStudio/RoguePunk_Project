using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunPowderCount : MonoBehaviour
{
    private Text text;
    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        if(gameObject.name == "CommonItemCount") text.text = "" + PlayerInventory.gunPowder[0];
        if(gameObject.name == "UncommonItemCount") text.text = "" + PlayerInventory.gunPowder[1];
        if(gameObject.name == "RareItemCount") text.text = "" + PlayerInventory.gunPowder[2];
        if(gameObject.name == "EpicItemCount") text.text = "" + PlayerInventory.gunPowder[3];
        if(gameObject.name == "LegendaryItemCount") text.text = "" + PlayerInventory.gunPowder[4];
    }
}
