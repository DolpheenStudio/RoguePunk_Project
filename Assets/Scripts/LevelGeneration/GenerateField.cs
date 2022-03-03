using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateField : MonoBehaviour
{
    public GameObject fieldPrefab;
    public GameObject wallPrefab;

    public void GenerateSquare(float squareX, float squareZ)
    {
        Instantiate(fieldPrefab, new Vector3(squareX * 5, 0f, squareZ * 5), Quaternion.Euler(0f, 0f, 0f));
    }
    public void GenerateWall(float wallX, float wallZ)
    {
        Instantiate(wallPrefab, new Vector3(wallX * 5, 0f, wallZ * 5), Quaternion.Euler(0f, 0f, 0f));
    }
}
