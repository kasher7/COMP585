using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


//Data Manipulation order

public class DataLogic
{
    public static void SaveGameData(DataObject myObject)
    {
        UpdateGameData(myObject);
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
        JsonUtility.FromJsonOverwrite(dataAsJson, myObject);
    }

    public static void UpdateGameData(DataObject myObject)
    {
        myObject.TotalEXP = myObject.StrengthEXP + myObject.CharismaEXP + 
            myObject.IntellectEXP;
        //TODO trigger event on level up
        myObject.PlayerLevel = myObject.TotalEXP / 100;
        myObject.StrengthLevel = myObject.StrengthEXP / 100;
        myObject.CharismaLevel = myObject.CharismaEXP / 100;
        myObject.IntellectLevel = myObject.IntellectEXP / 100;
     
        myObject.DailyTotalEXP[myObject.DayCounter] = myObject.DailyStrengthEXP[myObject.DayCounter] + 
            myObject.DailyIntellectEXP[myObject.DayCounter] + 
            myObject.DailyCharismaEXP[myObject.DayCounter];

        //Date and time stuff
        myObject.CurrentDate = System.DateTime.Now;
        myObject.DayCounter = System.Convert.ToInt32((myObject.CurrentDate - myObject.StartDate).TotalDays);



    }

    
}
