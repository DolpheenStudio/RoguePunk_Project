using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAid : MonoBehaviour
{
    public float healingValue = 20f;

    private Player player;
    private EndTeleport endTeleport;

    void Start()
    {
        player = FindObjectOfType<Player>();
        endTeleport = FindObjectOfType<EndTeleport>();
        if (Vector3.Distance(transform.position, player.transform.position) <= 30 || Vector3.Distance(transform.position, endTeleport.transform.position) <=3)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        transform.rotation = transform.rotation * Quaternion.Euler(0f, Time.deltaTime * 100, 0f);
        if(Vector3.Distance(transform.position, player.transform.position) <= 1.5f)
        {
            Destroy(gameObject);
            if ((player.maxPlayerHealth - player.currentPlayerHealth) > healingValue)
            {
                player.currentPlayerHealth += healingValue;
            }
            else player.currentPlayerHealth = player.maxPlayerHealth;
        }
    }
}
