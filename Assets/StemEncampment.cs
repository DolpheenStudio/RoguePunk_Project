using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StemEncampment : MonoBehaviour
{   
    public GameObject propeller;
    public GameObject gear1;
    public GameObject gear2;
    public GameObject gear3;
    public GameObject zeppelin;
    void Start()
    {
        if(SceneManager.GetActiveScene().name == "StemEncampment")
        {
            zeppelin.SetActive(false);
        }
    }

    void Update()
    {
        propeller.transform.rotation = propeller.transform.rotation * Quaternion.Euler(0f, 0f, 100f * Time.deltaTime);
        gear1.transform.rotation = gear1.transform.rotation * Quaternion.Euler(0f, 0f, 50f * Time.deltaTime);
        gear2.transform.rotation = gear2.transform.rotation * Quaternion.Euler(0f, 0f, -50f * Time.deltaTime);
        gear3.transform.rotation = gear3.transform.rotation * Quaternion.Euler(0f, 0f, 50f * Time.deltaTime);
    }
}
