using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndTeleport : MonoBehaviour
{
    private Player player;
    private bool isActive = false;
    public GameObject teleportParticles;
    
    void Start()
    {
        transform.rotation = Quaternion.Euler(-90f, transform.rotation.y, transform.rotation.z);
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        if(Vector3.Distance(transform.position, player.transform.position) <= 1 && PlayerUpgrade.generatedEnemies == 0)
        {
            Portal();
        }
        if(PlayerUpgrade.generatedEnemies == 0 && isActive == false)
        {
            isActive = true;
            Instantiate (teleportParticles, transform.position, transform.rotation);
        }
    }

    public void Portal()
    {
        if(PlayerUpgrade.isCrushDefeated == false)
        {
            if(PlayerUpgrade.playerLevelIteration < 5)
            {
                PlayerUpgrade.SetPlayerCurrentHealth(player.currentPlayerHealth);
                SavePlayerSystem.SavePlayer(player);
                PlayerUpgrade.playerLevelIteration++;
                SceneManager.LoadScene("CityOfStem", LoadSceneMode.Single);
            }
            else
            {
                PlayerUpgrade.SetPlayerCurrentHealth(player.currentPlayerHealth);
                SavePlayerSystem.SavePlayer(player);
                SceneManager.LoadScene("CrushArena", LoadSceneMode.Single);
            }
        }
        else 
        {
            PlayerUpgrade.SetPlayerCurrentHealth(player.currentPlayerHealth);
            SavePlayerSystem.SavePlayer(player);
            PlayerUpgrade.playerLevelIteration++;
            SceneManager.LoadScene("CityOfStemHyper", LoadSceneMode.Single);
        }
    }
}
