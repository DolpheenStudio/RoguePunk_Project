using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    float distance = 0f;
    Vector3 beginPos;
    private Player player;

    void Start()
    {
        player = FindObjectOfType<Player>();
        beginPos = transform.position;
    }
    void Update()
    {
        distance += Vector3.Distance(transform.position, beginPos);
        beginPos = transform.position;
        if (distance >= player.playerRange)
        {
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter(Collision coll)
    {
        Destroy(gameObject);
        if(coll.gameObject.tag == "Enemy")
        {
            Enemy enemy = coll.gameObject.GetComponentInParent<Enemy>();
            enemy.Damage(player.playerDamage);
        }
        if(coll.gameObject.tag == "Crate")
        {
            Crate crate = coll.gameObject.GetComponentInParent<Crate>();
            crate.Damage();
        }
    }
}
