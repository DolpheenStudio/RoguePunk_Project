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
    int direction = 0;
    int lastDirection = 2;
    int generatedFields = 0;
    int[,] generatedFieldsArray = new int[200, 200];

    public GenerateField generateField;
    public Player playerPrefab;

    void Start()
    {
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
                        generateField.GenerateSquare((float)x + 1, (float)z, generatedFields);

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
                        generateField.GenerateSquare((float)x, (float)z + 1, generatedFields);
                    }
                    z += 1;
                    break;
                case 3: //downwards
                    if (x - 2 < 0) break;
                    if (generatedFieldsArray[x - 1, z] != 1)
                    {
                        generatedFieldsArray[x - 1, z] = 1;
                        generatedFields++;
                        generateField.GenerateSquare((float)x - 1, (float)z, generatedFields);

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
                        generateField.GenerateSquare((float)x, (float)z - 1, generatedFields);
                    }
                    z -= 1;
                    break;
            }
            lastDirection = direction;
        }
        for(int x = 1; x < 199; x++)
        {
            for(int z = 1; z < 199; z++)
            {
                if (generatedFieldsArray[x, z] == 1)
                {
                    if (generatedFieldsArray[x - 1, z] != 1) generateField.GenerateWall((float)x - 1, (float)z);
                    if (generatedFieldsArray[x - 1, z + 1] != 1) generateField.GenerateWall((float)x - 1, (float)z + 1);
                    if (generatedFieldsArray[x - 1, z - 1] != 1) generateField.GenerateWall((float)x - 1, (float)z - 1);
                    if (generatedFieldsArray[x + 1, z] != 1) generateField.GenerateWall((float)x + 1, (float)z);
                    if (generatedFieldsArray[x + 1, z + 1] != 1) generateField.GenerateWall((float)x + 1, (float)z + 1);
                    if (generatedFieldsArray[x + 1, z - 1] != 1) generateField.GenerateWall((float)x + 1, (float)z - 1);
                    if (generatedFieldsArray[x, z + 1] != 1) generateField.GenerateWall((float)x, (float)z + 1);
                    if (generatedFieldsArray[x, z - 1] != 1) generateField.GenerateWall((float)x, (float)z - 1);
                }
            }
        }
        if(generatedFieldsArray[startX, startZ] != 1)
        {
            startX--;
            startZ--;
        }
        Instantiate(playerPrefab, new Vector3((float)startX * 5, 0, (float)startZ * 5), Quaternion.Euler(0f, 0f, 0f));
        generateField.GenerateEnd(endX-2, endZ);
    }
}
