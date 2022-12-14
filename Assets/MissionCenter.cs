using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MissionCenter : MonoBehaviour
{
    public Transform missionCenterHologram;
    public GameObject canvas;
    public Player player;
    public Text text;

    void Start()
    {
        canvas.SetActive(false);
        player = FindObjectOfType<Player>();
        StartCoroutine(LateStart(0.5f));
    }
    IEnumerator LateStart(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        if(PlayerUpgrade.isCrushDefeated)
        {
            text.color = Color.red;
        }
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
        if(PlayerUpgrade.isCrushDefeated == false)
        {
            SceneManager.LoadScene("CityOfStem", LoadSceneMode.Single);
            PlayerUpgrade.playerLevelIteration = 1;
        }
        else
        {
            SceneManager.LoadScene("CityOfStemHyper", LoadSceneMode.Single);
            PlayerUpgrade.playerLevelIteration = 10;
        }
    }
}
