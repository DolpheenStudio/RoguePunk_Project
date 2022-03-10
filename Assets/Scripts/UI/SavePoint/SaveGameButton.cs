using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveGameButton : MonoBehaviour
{
    private Player player;
    public GameObject saveInfo;
    void Start()
    {
        saveInfo.SetActive(false);
        player = FindObjectOfType<Player>();
    }

    public void SaveGame() 
    {
        player.SavePlayer();
        StartCoroutine(ShowSaveInfo());
    }

    IEnumerator ShowSaveInfo()
    {
        saveInfo.SetActive(true);
        yield return new WaitForSeconds(2f);
        saveInfo.SetActive(false);
    }
}
