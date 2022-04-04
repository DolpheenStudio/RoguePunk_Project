using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    private Player player;
    private float position;
    void Start()
    {
        player = FindObjectOfType<Player>();
    }

    
    void Update()
    {
        if(Vector3.Distance(new Vector3(player.transform.position.x, 0f, player.transform.position.z), 
                            new Vector3(transform.position.x, 0f, transform.position.z)) <= 15 &&
                            (player.transform.position.x < transform.position.x - 3 || player.transform.position.z < transform.position.z - 3))
        {
            transform.position = new Vector3(transform.position.x, position, transform.position.z);
            if(position >= -4) position -= Time.deltaTime * 20f;
        }
        else
        {
            transform.position = new Vector3(transform.position.x, position, transform.position.z);
            if(position <= 0) position += Time.deltaTime * 20f;
        }
    }
}
