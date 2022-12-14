using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BossCounter : MonoBehaviour
{
    public Player player;
    public Text text;
    public float cooldown = 5f;
    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        text.text = "RETURN IN " + (int) cooldown;
        cooldown -= Time.deltaTime;
        if(cooldown <= 0.05f)
        {
            player.Death();
        }
    }
}
