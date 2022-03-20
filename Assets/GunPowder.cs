using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPowder : MonoBehaviour
{
    public Material common;
    public Material uncommon;
    public Material rare;
    private Player player;
    private int rarity;
    void Start()
    {
        player = FindObjectOfType<Player>();
        if(Random.value > 0.58)
        {
            rarity = 0;
        }
        else if(Random.value > 0.71)
        {
            rarity = 1;
        }
        else if(Random.value > 0.83)
        {
            rarity = 2;
        }
        if(rarity == 0)
        {
            foreach (MeshRenderer render in GetComponentsInChildren<MeshRenderer>())
            {
                render.material = common;
            }
        }
        if(rarity == 1)
        {
            foreach (MeshRenderer render in GetComponentsInChildren<MeshRenderer>())
            {
                render.material = uncommon;
            }
        }
        if(rarity == 2)
        {
            foreach (MeshRenderer render in GetComponentsInChildren<MeshRenderer>())
            {
                render.material = rare;
            }
        }
    }

    void Update()
    {
        if(Vector3.Distance(transform.position, player.transform.position) <= 1f)
        {
            Destroy(gameObject);
            PlayerInventory.AddGunPowder(rarity);
        }
    }
}
