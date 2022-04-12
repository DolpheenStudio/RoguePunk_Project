using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissionCenter : MonoBehaviour
{
    public Transform missionCenterHologram;
    public GameObject canvas;
    public Player player;
    void Start()
    {
        canvas.SetActive(false);
        player = FindObjectOfType<Player>();
    }

    
    void Update()
    {
        missionCenterHologram.rotation *= Quaternion.Euler(0f, 20f * Time.deltaTime, 0f);
        if(Vector3.Distance(player.transform.position, transform.position) <= 4f)
        {
            canvas.SetActive(true);
        }
        else
        {
            canvas.SetActive(false);
        }
    }

    public void CityOfStemStart()
    {
        SceneManager.LoadScene("CityOfStem", LoadSceneMode.Single);
        PlayerUpgrade.playerLevelIteration = 1;
    }
}
