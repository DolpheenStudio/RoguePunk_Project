using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaGenerator : MonoBehaviour
{
    public GameObject floor1Prefab;
    public GameObject floor2Prefab;
    public GameObject floor3Prefab;
    public GameObject wall1Prefab;
    public GameObject wall2Prefab;
    private int[,] arena = new int[11, 11];
    private int floor;
    void Start()
    {
        for(int i=0; i<11; i++)
        {
            for(int j=0; j<11; j++)
            {
                if(i == 0 || j == 0 || i == 10 || j == 10)
                {
                    if(Random.Range(1, 3) == 1) Instantiate(wall1Prefab, new Vector3(i * 5, 0f, j * 5), Quaternion.Euler(0f, 0f, 0f));
                    else Instantiate(wall2Prefab, new Vector3(i * 5, 0f, j * 5), Quaternion.Euler(0f, 0f, 0f));
                }
                else
                {
                    floor = Random.Range(1, 4);
                    if(floor == 1) Instantiate(floor1Prefab, new Vector3(i * 5, 0f, j * 5), Quaternion.Euler(0f, 0f, 0f));
                    else if(floor == 2) Instantiate(floor2Prefab, new Vector3(i * 5, 0f, j * 5), Quaternion.Euler(0f, 0f, 0f));
                    else if (floor == 3) Instantiate(floor3Prefab, new Vector3(i * 5, 0f, j * 5), Quaternion.Euler(0f, 0f, 0f));
                }
            }
        }
    }
    void Update()
    {
        
    }
}
