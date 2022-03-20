using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PlayerInventory
{
    public static int[] gunPowder {get; set;} = new int [5]; //index: 0 - common; 1 - uncommon; 2 - rare; 3 - epic; 4 - legendary
    public static int[] metalPlate {get; set;} = new int[5]; //index: 0 - common; 1 - uncommon; 2 - rare; 3 - epic; 4 - legendary
    public static int[] bearing {get; set;} = new int[5]; //index: 0 - common; 1 - uncommon; 2 - rare; 3 - epic; 4 - legendary

    public static void ResetItems()
    {
        for(int i=0; i<5; i++)
        {
            gunPowder[i] = 0;
            metalPlate[i] = 0;
            bearing[i] = 0;
        }
    }

    public static void AddGunPowder(int rarity)
    {
        if(rarity == 0) gunPowder[rarity]++;
        if(rarity == 1) gunPowder[rarity]++;
        if(rarity == 2) gunPowder[rarity]++;
        if(rarity == 3) gunPowder[rarity]++;
        if(rarity == 4) gunPowder[rarity]++;
    }
    public static void AddMetalPlate(int rarity)
    {
        if(rarity == 0) metalPlate[rarity]++;
        if(rarity == 1) metalPlate[rarity]++;
        if(rarity == 2) metalPlate[rarity]++;
        if(rarity == 3) metalPlate[rarity]++;
        if(rarity == 4) metalPlate[rarity]++;
    }
    public static void AddBearing(int rarity)
    {
        if(rarity == 0) bearing[rarity]++;
        if(rarity == 1) bearing[rarity]++;
        if(rarity == 2) bearing[rarity]++;
        if(rarity == 3) bearing[rarity]++;
        if(rarity == 4) bearing[rarity]++;
    }
}
