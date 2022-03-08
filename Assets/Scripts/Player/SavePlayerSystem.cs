using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SavePlayerSystem
{
    public static void SavePlayer(Player player) 
    {
        BinaryFormatter formatter = new BinaryFormatter();

        string path = Application.persistentDataPath + "/player.rp";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerUpgradeData data = new PlayerUpgradeData(player);

        formatter.Serialize(stream, data);

        stream.Close();
    }

    public static PlayerUpgradeData LoadPlayer ()
    {
        string path = Application.persistentDataPath + "/player.rp";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerUpgradeData data = formatter.Deserialize(stream) as PlayerUpgradeData;

            stream.Close();
            return data;
        }
        else 
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
