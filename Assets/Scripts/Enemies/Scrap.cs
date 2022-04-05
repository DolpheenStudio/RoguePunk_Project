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
        if(pullbackCooldown <= 0) transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.transform.position.x, 1f, player.transform.position.z), 12*Time.deltaTime);
        else pullbackCooldown -= Time.deltaTime;

        if(Vector3.Distance(transform.position, player.transform.position) <= 1) 
        {
            Destroy(gameObject);
            player.playerScraps++;
        }
    }
}
