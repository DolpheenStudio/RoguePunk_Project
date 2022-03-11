using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrapText : MonoBehaviour
{
    public Player player;
    private Text scrapInfo;
    void Start()
    {
        scrapInfo = GetComponent<Text>();
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        scrapInfo.text = "Scraps: " + player.playerScraps + " " + Cursor.visible;
    }
}
