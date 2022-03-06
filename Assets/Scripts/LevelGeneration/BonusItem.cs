using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusItem : MonoBehaviour
{
    public Player player;
    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        transform.rotation = transform.rotation * Quaternion.Euler(0f, 0f, Time.deltaTime * 50);
        if(Vector3.Distance(transform.position, player.transform.position) <= 2)
        {
            Destroy(gameObject);
            if(gameObject.tag == "AttackSpeedBonus")
            {
                PlayerUpgrade.playerBonusAttackSpeed++;
                player.ReloadPlayerBonus();
            }
            if(gameObject.tag == "BulletSpeedBonus")
            {
                PlayerUpgrade.playerBonusBulletSpeed++;
                player.ReloadPlayerBonus();
            }
            if(gameObject.tag == "DamageBonus")
            {
                PlayerUpgrade.playerBonusDamage++;
                player.ReloadPlayerBonus();
            }
            if(gameObject.tag == "DoubleShotBonus")
            {
                PlayerUpgrade.playerDoubleShot = true;
                player.ReloadPlayerBonus();
            }
            if(gameObject.tag == "EmptyHealthBonus")
            {
                PlayerUpgrade.playerBonusEmptyHealth++;
                player.ReloadPlayerBonus();
            }
            if(gameObject.tag == "HealthBonus")
            {
                PlayerUpgrade.playerBonusHealth++;
                player.currentPlayerHealth += 20f;
                player.ReloadPlayerBonus();
            }
            if(gameObject.tag == "RangeBonus")
            {
                PlayerUpgrade.playerBonusRange++;
                player.ReloadPlayerBonus();
            }
        }
    }
}
