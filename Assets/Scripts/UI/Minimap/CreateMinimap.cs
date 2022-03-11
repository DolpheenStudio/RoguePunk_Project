using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMinimap : MonoBehaviour
{
    public GameObject fieldPrefab;
    public GameObject wallPrefab;
    public GameObject minimapCamera;
    public MinimapCamera minimapCameraClass;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GenerateMinimapField(float squareX, float squareZ)
    {
        Instantiate(fieldPrefab, new Vector3(squareX * 5 + 1000, 0f, squareZ * 5), Quaternion.Euler(0f, 0f, 0f));
    }
    public void GenerateMinimapWall(float wallX, float wallZ)
    {
        Instantiate(wallPrefab, new Vector3(wallX * 5 + 1000, 0f, wallZ * 5), Quaternion.Euler(0f, 0f, 0f));
    }
    public void SetMiddle(float startX, float endX, float startZ, float endZ)
    {
        float middleX = (startX + endX) / 2 + 1000;
        float middleZ = (startZ + endZ) / 2;
        minimapCamera.transform.position = new Vector3(middleX, 900f, middleZ);
        minimapCameraClass.SetCameraFOV(startZ, endZ, startX, endX);
    }
}
