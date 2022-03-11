using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider slider;
    public Image fill;
    public Text text;
    private Player player;

    void Start()
    {
        player = FindObjectOfType<Player>();
    }
    void Update()
    {
        text.text = player.currentPlayerHealth + " / " + player.maxPlayerHealth;
    }

    public void SetMaxHealth(float health)
    {
        slider.maxValue = health;
        slider.value = health;
    }

    public void SetHealth(float health)
    {
        slider.value = health;
    }

}    
