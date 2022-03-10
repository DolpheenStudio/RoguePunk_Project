using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrapCounter : MonoBehaviour
{
    public Text text;
    private Player player;

    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        text.text = "" + player.playerScraps;
    }
}
