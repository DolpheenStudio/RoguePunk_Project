using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxPlayerHealth = 100f;
    public float playerRange = 10f;
    public float playerBulletSpeed = 15f;
    public float playerAttackSpeed = 1f;
    float currentPlayerHealth = 0f;

    void Start()
    {
        currentPlayerHealth = maxPlayerHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
