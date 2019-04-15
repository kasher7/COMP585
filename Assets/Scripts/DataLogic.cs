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
        UpdateGameData(myObject);
        string filePath = Application.dataPath + "/Data/Data.json";
        string dataAsJson = File.ReadAllText(filePath);
        myObject = JsonUtility.FromJson<DataObject>(dataAsJson);
    }

    public static void UpdateGameData(DataObject myObject)
    {
        myObject.TotalEXP = myObject.StrengthEXP + myObject.CharismaEXP + 
            myObject.IntellectEXP;
        //TODO trigger event on level up
        myObject.PlayerLevel = myObject.TotalEXP % 100;
        myObject.StrengthLevel = myObject.StrengthEXP % 100;
        myObject.CharismaLevel = myObject.CharismaEXP % 100;
        myObject.IntellectLevel = myObject.IntellectEXP % 100;

        //Date and time stuff
        myData.CurrentDate = System.DateTime.Now.ToString().Split('/', ' ', ':');



    }

    
}
