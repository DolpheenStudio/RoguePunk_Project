using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstAid : MonoBehaviour
{
    public Player player;
    public float healingValue = 20f;

    void Start()
    {
        player = FindObjectOfType<Player>();
        if (Vector3.Distance(transform.position, player.transform.position) <= 30)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        transform.rotation = transform.rotation * Quaternion.Euler(0f, Time.deltaTime * 100, 0f);
        if(Vector3.Distance(transform.position, player.transform.position) <= 1)
        {
            Destroy(gameObject);
            if ((player.maxPlayerHealth - player.currentPlayerHealth) > healingValue)
            {
                player.currentPlayerHealth += healingValue;
            }
            else player.currentPlayerHealth = 100;
        }
    }
}
