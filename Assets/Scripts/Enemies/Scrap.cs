using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrap : MonoBehaviour
{
    private Player player;
    private float pullbackCooldown;
    void Start()
    {
        player = FindObjectOfType<Player>();
        pullbackCooldown = Random.Range(0.5f, 1f);
    }

    void Update()
    {
        if(pullbackCooldown <= 0) transform.position = Vector3.Lerp(transform.position, player.transform.position, Time.deltaTime * 3);
        else pullbackCooldown -= Time.deltaTime;

        if(Vector3.Distance(transform.position, player.transform.position) <= 0.5) 
        {
            Destroy(gameObject);
            player.playerScraps++;
        }
    }
}
