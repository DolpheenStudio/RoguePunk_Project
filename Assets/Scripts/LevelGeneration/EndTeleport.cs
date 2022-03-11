using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndTeleport : MonoBehaviour
{
    private Player player;
    
    void Start()
    {
        transform.rotation = Quaternion.Euler(-90f, transform.rotation.y, transform.rotation.z);
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        if(Vector3.Distance(transform.position, player.transform.position) <= 1)
        {
            Portal();
        }
    }

    public void Portal()
    {
        PlayerUpgrade.SetPlayerCurrentHealth(player.currentPlayerHealth);
        SavePlayerSystem.SavePlayer(player);
        PlayerUpgrade.playerLevelIteration++;
        SceneManager.LoadScene("GeneratedLevel", LoadSceneMode.Single);
    }
}
