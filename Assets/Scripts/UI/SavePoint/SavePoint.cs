using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SavePoint : MonoBehaviour
{
    private Player player;
    public GameObject canvas;
    public GameObject saveInfo;
    void Start()
    {
        player = FindObjectOfType<Player>();
        canvas.SetActive(false);
    }
    void Update()
    {
        if(Vector3.Distance(transform.position, player.transform.position) <= 1f)
        {
            canvas.SetActive(true);
            Cursor.visible = true;
        }
        else 
        {
            canvas.SetActive(false);
            Cursor.visible = false;
            saveInfo.SetActive(false);
        }
    }
}
