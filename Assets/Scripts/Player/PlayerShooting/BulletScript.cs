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
        if(coll.gameObject.tag != "Player")
        {
            Debug.Log("Collision with" + coll.gameObject.name);
            Destroy(gameObject);
        }
    }
}
