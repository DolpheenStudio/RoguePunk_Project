using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BearingCount : MonoBehaviour
{
    private Text text;
    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        if(gameObject.name == "CommonItemCount") text.text = "" + PlayerInventory.bearing[0];
        if(gameObject.name == "UncommonItemCount") text.text = "" + PlayerInventory.bearing[1];
        if(gameObject.name == "RareItemCount") text.text = "" + PlayerInventory.bearing[2];
        if(gameObject.name == "EpicItemCount") text.text = "" + PlayerInventory.bearing[3];
        if(gameObject.name == "LegendaryItemCount") text.text = "" + PlayerInventory.bearing[4];
    }
}