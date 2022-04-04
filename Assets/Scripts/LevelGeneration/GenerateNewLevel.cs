using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateNewLevel : MonoBehaviour
{
    public int worldSize;
    int x = 100;
    int startX = 0;
    int startZ;
    int z = 100;
    int endX = 200;
    int endZ;
    int leftZ = 0;
    int rightZ = 200;
    int direction = 0;
    int lastDirection = 2;
    int generatedFields = 0;
    int[,] generatedFieldsArray = new int[200, 200];

    public GenerateField generateField;
    public CreateMinimap createMinimap;
    public Player playerPrefab;
    public GameObject minimapPlayerPointer;

    void Start()
    {
        PlayerUpgrade.generatedEnemies = 0;
        while(generatedFields <= worldSize)
        {
            do
            {
                direction = Random.Range(1, 5);
            } while (direction + lastDirection % 2 == 0);
            switch(direction)
            {
                case 1: //upwards
                    if(x + 2 > 199) break;
                    if(generatedFieldsArray[x + 1, z] != 1)
                    {
                        generatedFieldsArray[x + 1, z] = 1;
                        generatedFields++;

                        if(x + 1 > startX)
                        {
                            startX = x + 1;
                            startZ = z;
                        }
                    }
                    x += 1;
                    break;
                case 2: //right
                    if (z + 2 > 199) break;
                    if (generatedFieldsArray[x, z + 1] != 1)
                    {
                        generatedFieldsArray[x, z + 1] = 1;
                        generatedFields++;

                        if(rightZ >= z + 1)
                        {
                            rightZ = z + 1;
                        }
                    }
                    z += 1;
                    break;
                case 3: //downwards
                    if (x - 2 < 0) break;
                    if (generatedFieldsArray[x - 1, z] != 1)
                    {
                        generatedFieldsArray[x - 1, z] = 1;
                        generatedFields++;

                        if (x - 1 < endX)
                        {
                            endX = x + 1;
                            endZ = z;
                        }
                    }
                    x -= 1;
                    break;
                case 4: //left
                    if (z - 2 < 0) break;
                    if (generatedFieldsArray[x, z - 1] != 1)
                    {
                        generatedFieldsArray[x, z - 1] = 1;
                        generatedFields++;

                        if(leftZ <= z - 1)
                        {
                            leftZ = z - 1;
                        }
                    }
                    z -= 1;
                    break;
            }
            lastDirection = direction;
        }
        if(generatedFieldsArray[startX, startZ] != 1)
        {
            startX--;
            startZ--;
        }
        createMinimap.SetMiddle((float) startX * 5, (float) endX * 5, (float) leftZ * 5, rightZ * 5);
        Instantiate(playerPrefab, new Vector3((float)startX * 5, 0, (float)startZ * 5), Quaternion.Euler(0f, 0f, 0f));
        Instantiate(minimapPlayerPointer, new Vector3((float)startX * 5 + 1000, 0, (float)startZ * 5), Quaternion.Euler(0f, 0f, 0f));
        generateField.GenerateEnd(endX-2, endZ);
        generatedFields = 0;
        for(int x = 1; x < 199; x++)
        {
            for(int z = 1; z < 199; z++)
            {
                if (generatedFieldsArray[x, z] == 1)
                {
                    generateField.GenerateSquare((float)x, (float)z, generatedFields);
                    createMinimap.GenerateMinimapField((float)x, (float)z);
                    generatedFields++;
                    if (generatedFieldsArray[x - 1, z] != 1 && generatedFieldsArray[x - 1, z] != 2) 
                    {
                        generateField.GenerateWall((float)x - 1, (float)z);
                        createMinimap.GenerateMinimapWall((float)x - 1, (float)z);
                        generatedFieldsArray[x - 1, z] = 2;
                    }
                    if (generatedFieldsArray[x - 1, z + 1] != 1 && generatedFieldsArray[x - 1, z + 1] != 2)
                    {
                        generateField.GenerateWall((float)x - 1, (float)z + 1);
                        createMinimap.GenerateMinimapWall((float)x - 1, (float)z + 1);
                        generatedFieldsArray[x - 1, z + 1] = 2;
                    } 
                    if (generatedFieldsArray[x - 1, z - 1] != 1 && generatedFieldsArray[x - 1, z - 1] != 2)
                    {
                        generateField.GenerateWall((float)x - 1, (float)z - 1);
                        createMinimap.GenerateMinimapWall((float)x - 1, (float)z - 1);
                        generatedFieldsArray[x - 1, z - 1] = 2;
                    } 
                    if (generatedFieldsArray[x + 1, z] != 1 && generatedFieldsArray[x + 1, z] != 2)
                    {
                        generateField.GenerateWall((float)x + 1, (float)z);
                        createMinimap.GenerateMinimapWall((float)x + 1, (float)z);
                        generatedFieldsArray[x + 1, z] = 2;
                    } 
                    if (generatedFieldsArray[x + 1, z + 1] != 1 && generatedFieldsArray[x + 1, z + 1] != 1)
                    {
                        generateField.GenerateWall((float)x + 1, (float)z + 1);
                        createMinimap.GenerateMinimapWall((float)x + 1, (float)z + 1);
                        generatedFieldsArray[x + 1, z + 1] = 2;
                    } 
                    if (generatedFieldsArray[x + 1, z - 1] != 1 && generatedFieldsArray[x + 1, z - 1] != 2)
                    {
                        generateField.GenerateWall((float)x + 1, (float)z - 1);
                        createMinimap.GenerateMinimapWall((float)x + 1, (float)z - 1);
                        generatedFieldsArray[x + 1, z - 1] = 2;
                    } 
                    if (generatedFieldsArray[x, z + 1] != 1 && generatedFieldsArray[x, z + 1] != 2)
                    {
                        generateField.GenerateWall((float)x, (float)z + 1);
                        createMinimap.GenerateMinimapWall((float)x, (float)z + 1);
                        generatedFieldsArray[x, z + 1] = 2;
                    } 
                    if (generatedFieldsArray[x, z - 1] != 1 && generatedFieldsArray[x, z - 1] != 2)
                    {
                        generateField.GenerateWall((float)x, (float)z - 1);
                        createMinimap.GenerateMinimapWall((float)x, (float)z - 1);
                        generatedFieldsArray[x, z - 1] = 2;
                    } 
                }
            }
        }
    }
}
