using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerInventoryData
{
    public int[] gunPowder = new int[5];
    public int[] metalPlate = new int[5];
    public int[] bearing = new int[5];

    public PlayerInventoryData()
    {
        for(int i=0; i<5; i++)
        {
            gunPowder[i] = PlayerInventory.gunPowder[i];
            metalPlate[i] = PlayerInventory.metalPlate[i];
            bearing[i] = PlayerInventory.bearing[i];
        }
    }
}
