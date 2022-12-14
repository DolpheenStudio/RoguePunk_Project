using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunPowder : MonoBehaviour
{
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
            ParticleSystem ps = GetComponentInChildren<ParticleSystem>();
            ParticleSystem.MainModule ma = ps.main;
            ma.startColor = Color.white;
        }
        if(rarity == 1)
        {
            ParticleSystem ps = GetComponentInChildren<ParticleSystem>();
            ParticleSystem.MainModule ma = ps.main;
            ma.startColor = Color.green;
        }
        if(rarity == 2)
        {
            ParticleSystem ps = GetComponentInChildren<ParticleSystem>();
            ParticleSystem.MainModule ma = ps.main;
            ma.startColor = Color.blue;
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
