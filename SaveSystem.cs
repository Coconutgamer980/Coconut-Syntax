using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SaveSystem
{
    public static void SaveMenu (Menu menu)
    {
        BinaryFormatter formatter = new BinaryFormatter();


        string path = Application.persistentDataPath + "/menu.data";
        FileStream stream = new FileStream(path, FileMode.Create);

        MenuData data = new MenuData(menu);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static MenuData LoadMenu ()
    {
        string path = Application.persistentDataPath + "/menu.data";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            MenuData data = formatter.Deserialize(stream) as MenuData;
            stream.Close();


            return data;
        }
        else
        {
            Debug.LogError("Save file not found in" + path);
            return null;
        }
    }

}
