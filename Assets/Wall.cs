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
        position = 0f;
    }

    
    void FixedUpdate()
    {
        if(Vector3.Distance(new Vector3(player.transform.position.x, 0f, player.transform.position.z), 
                            new Vector3(transform.position.x, 0f, transform.position.z)) <= 30 &&
                            ((player.transform.position.x + player.transform.position.z) <= (transform.position.x + transform.position.z) + 5))
        {
            transform.position = new Vector3(transform.position.x, position, transform.position.z);
            if (position >= -5) position -= Time.deltaTime * 20f;
        }
        else
        {
            transform.position = new Vector3(transform.position.x, position, transform.position.z);
            if(position <= -0.1) position += Time.deltaTime * 20f;
        }
    }
}
