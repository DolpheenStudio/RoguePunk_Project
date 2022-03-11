using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateField : MonoBehaviour
{
    public GameObject fieldPrefab;
    public GameObject wallPrefab;
    public GameObject endPortalPrefab;
    public GameObject itemSlotPrefab;
    public GameObject bumperPrefab;
    public GameObject izzyPrefab;
    public GameObject blinkyPrefab;
    public GameObject firstAidPrefab;
    public GameObject bonusAttackSpeedPrefab;
    public GameObject bonusBulletSpeedPrefab;
    public GameObject bonusDamagePrefab;
    public GameObject bonusHealthPrefab;
    public GameObject bonusEmptyHealthPrefab;
    public GameObject bonusRangePrefab;
    public GameObject bonusDoubleShotPrefab;
    public GameObject allStatsUpPrefab;

    private bool itemSpawned = false;

    public void GenerateSquare(float squareX, float squareZ, int generatedSquares)
    {
        if(generatedSquares == 250 || generatedSquares == 500 || generatedSquares == 750)
        {
            Instantiate(itemSlotPrefab, new Vector3(squareX * 5, 0f, squareZ * 5), Quaternion.Euler(0f, 0f, 0f));
            while (itemSpawned == false)
            {
                if(Random.value > 0.85)
                {
                    Instantiate(bonusAttackSpeedPrefab, new Vector3(squareX * 5, 1.5f, squareZ * 5), Quaternion.Euler(90f, 0f, 0f));
                    itemSpawned = true;
                }
                else if(Random.value > 0.85)
                {
                    Instantiate(bonusBulletSpeedPrefab, new Vector3(squareX * 5, 1.5f, squareZ * 5), Quaternion.Euler(90f, 0f, 0f));
                    itemSpawned = true;
                }
                else if(Random.value > 0.85)
                {
                    Instantiate(bonusDamagePrefab, new Vector3(squareX * 5, 1.5f, squareZ * 5), Quaternion.Euler(90f, 0f, 0f));
                    itemSpawned = true;
                }
                else if(Random.value > 0.85)
                {
                    Instantiate(bonusEmptyHealthPrefab, new Vector3(squareX * 5, 1.5f, squareZ * 5), Quaternion.Euler(90f, 0f, 0f));
                    itemSpawned = true;
                }
                else if(Random.value > 0.85)
                {
                    Instantiate(bonusHealthPrefab, new Vector3(squareX * 5, 1.5f, squareZ * 5), Quaternion.Euler(90f, 0f, 0f));
                    itemSpawned = true;
                }
                else if(Random.value > 0.85)
                {
                    Instantiate(bonusRangePrefab, new Vector3(squareX * 5, 1.5f, squareZ * 5), Quaternion.Euler(90f, 0f, 0f));
                    itemSpawned = true;
                }
                else if(Random.value > 0.95 && PlayerUpgrade.playerDoubleShot == false)
                {
                    Instantiate(bonusDoubleShotPrefab, new Vector3(squareX * 5, 1.5f, squareZ * 5), Quaternion.Euler(90f, 0f, 0f));
                    itemSpawned = true;
                }
                else if(Random.value > 0.95)
                {
                    Instantiate(allStatsUpPrefab, new Vector3(squareX * 5, 1.5f, squareZ * 5), Quaternion.Euler(90f, 0f, 0f));
                    itemSpawned = true;
                }
            }
            itemSpawned = false;
        }
        else 
        {
            Instantiate(fieldPrefab, new Vector3(squareX * 5, 0f, squareZ * 5), Quaternion.Euler(0f, 0f, 0f));

            if (Random.value > 0.95)
            {
                Instantiate(bumperPrefab, new Vector3(squareX * 5, 0.25f, squareZ * 5), Quaternion.Euler(0f, 0f, 0f));
            }
            else if (Random.value > 0.95)
            {
                Instantiate(izzyPrefab, new Vector3(squareX * 5, 0.25f, squareZ * 5), Quaternion.Euler(0f, 0f, 0f));
            }
            else if (Random.value > 0.95)
            {
                Instantiate(blinkyPrefab, new Vector3(squareX * 5, 0.25f, squareZ * 5), Quaternion.Euler(0f, 0f, 0f));
            }
            else if (Random.value > 0.98)
            {
                Instantiate(firstAidPrefab, new Vector3(squareX * 5, 0.25f, squareZ * 5), Quaternion.Euler(0f, 0f, 0f));
            }
        }
    }
    public void GenerateWall(float wallX, float wallZ)
    {
        Instantiate(wallPrefab, new Vector3(wallX * 5, 0f, wallZ * 5), Quaternion.Euler(0f, 0f, 0f));
    }
    public void GenerateEnd(float endX, float endZ)
    {
        Instantiate(endPortalPrefab, new Vector3(endX * 5, 0f, endZ * 5), Quaternion.Euler(0f, 0f, 0f));
    }
}
