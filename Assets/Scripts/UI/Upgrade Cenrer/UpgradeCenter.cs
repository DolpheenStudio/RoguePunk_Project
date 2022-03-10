using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeCenter : MonoBehaviour
{
    private Player player;
    public GameObject canvas;
    void Start()
    {
        player = FindObjectOfType<Player>();
        canvas.SetActive(false);
    }

    void Update()
    {
        Debug.Log(Vector3.Distance(transform.position, player.transform.position));
        if(Vector3.Distance(transform.position, player.transform.position) <= 1.5) 
        {
            canvas.SetActive(true);
            Cursor.visible = true;
        }
        else 
        {
            canvas.SetActive(false);
            Cursor.visible = false;
        }
    }
}
