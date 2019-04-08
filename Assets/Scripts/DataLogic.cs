using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class DataLogic : MonoBehaviour
{
    public void SaveGameData(DataObject myObject)
    {
        string dataAsJson = JsonUtility.ToJson(myObject);
        string filePath = Application.dataPath + "/Data/Data.json";
        Debug.Log(filePath);
        File.WriteAllText(filePath, dataAsJson);
    }

    public void LoadGameData(DataObject myObject)
    {
        string filePath = Application.dataPath + "/Data/Data.json";
        string dataAsJson = File.ReadAllText(filePath);
        myObject = JsonUtility.FromJson<DataObject>(dataAsJson);
    }
    
}
