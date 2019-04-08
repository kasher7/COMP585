using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataLogic
{
    public static void SaveGameData(DataObject myObject)
    {
        string dataAsJson = JsonUtility.ToJson(myObject);
        string filePath = Application.dataPath + "/Data/Data.json";
        Debug.Log(dataAsJson);
        File.WriteAllText(filePath, dataAsJson);
    }

    public static void LoadGameData(DataObject myObject)
    {
        string filePath = Application.dataPath + "/Data/Data.json";
        string dataAsJson = File.ReadAllText(filePath);
        myObject = JsonUtility.FromJson<DataObject>(dataAsJson);
    }

    
}
