using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SavePlayerSystem
{
    public static void SavePlayer(Player player) 
    {
        BinaryFormatter formatter = new BinaryFormatter();

        //Save Player Upgrade Info
        string pathPlayer = Application.persistentDataPath + "/player.rp";
        FileStream stream = new FileStream(pathPlayer, FileMode.Create);

        PlayerUpgradeData data = new PlayerUpgradeData(player);

        formatter.Serialize(stream, data);
        stream.Close();
        //Save Player Inventory Info

        string pathInventory = Application.persistentDataPath + "/playerInventory.rp";

        FileStream stream2 = new FileStream(pathInventory, FileMode.Create);

        PlayerInventoryData inventoryData = new PlayerInventoryData();

        formatter.Serialize(stream2, inventoryData);
        stream2.Close();
    }

    public static void RemoveSaveFile()
    {
        string pathInventory = Application.persistentDataPath + "/playerInventory.rp";
        string pathPlayer = Application.persistentDataPath + "/player.rp";
        File.Delete(pathInventory);
        File.Delete(pathPlayer);
    }

    public static PlayerUpgradeData LoadPlayer ()
    {
        string path = Application.persistentDataPath + "/player.rp";
        string pathInventory = Application.persistentDataPath + "/playerInventory.rp";

        if(File.Exists(path) && File.Exists(pathInventory))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerUpgradeData data = formatter.Deserialize(stream) as PlayerUpgradeData;

            stream.Close();

            FileStream stream2 = new FileStream(pathInventory, FileMode.Open);
            PlayerInventoryData inventoryData = formatter.Deserialize(stream2) as PlayerInventoryData;
            for(int i=0; i<5; i++)
            {
                PlayerInventory.gunPowder[i] = inventoryData.gunPowder[i];
                PlayerInventory.metalPlate[i] = inventoryData.metalPlate[i];
                PlayerInventory.bearing[i] = inventoryData.bearing[i];
            }

            stream2.Close();

            return data;
        }
        else 
        {
            Debug.LogError("Save file not found in " + path + " or " + pathInventory);
            return null;
        }
    }
}
