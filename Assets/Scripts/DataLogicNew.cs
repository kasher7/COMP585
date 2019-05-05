using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

//Data Manipulation order

public class DataLogicNew
{
    public static void SaveGameDataNew(DataObject myObject)
    {
        UpdateData(myObject);
        var dataAsJson = JsonUtility.ToJson(myObject);
        var startDateAsJson = JsonUtility.ToJson((JsonDateTime)myObject.StartDate);
        var currentDateAsJson = JsonUtility.ToJson((JsonDateTime)myObject.CurrentDate);
        string filePath = Application.dataPath + "/Data/Data.json";
        string startDateFilePath = Application.dataPath + "/Data/StartDate.json";
        string currentDateFilePath = Application.dataPath + "/Data/CurrentDate.json";
        Debug.Log(dataAsJson);
        File.WriteAllText(filePath, dataAsJson);
        File.WriteAllText(startDateFilePath, startDateAsJson);
        File.WriteAllText(currentDateFilePath, currentDateAsJson);
    }
    public static void Save(DataObject myObject)
    {
        UpdateData(myObject);
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/Data.dat");

        bf.Serialize(file, myObject);
        file.Close();
    }

    public static DataObject Load()
    {
        if (File.Exists(Application.persistentDataPath + "/Data.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/Data.dat", FileMode.Open);
            DataObject data = (DataObject)bf.Deserialize(file);
            file.Close();

            return data;
        }else{
            FileStream file = File.Create(Application.persistentDataPath + "/Data.dat");
            DataObject data = new DataObject();
            return data;
        }
    }

    public static void LoadGameDataNew(DataObject myObject)
    {
        UpdateData(myObject);
        string filePath = Application.dataPath + "/Data/Data.json";
        string startDateFilePath = Application.dataPath + "/Data/StartDate.json";
        string currentDateFilePath = Application.dataPath + "/Data/CurrentDate.json";

        string dataAsJson = File.ReadAllText(filePath);
        var startDateAsJson = File.ReadAllText(startDateFilePath);
        var currentDateAsJson = File.ReadAllText(currentDateFilePath);
        JsonUtility.FromJsonOverwrite(dataAsJson, myObject);
        myObject.StartDate = (System.DateTime)JsonUtility.FromJson<JsonDateTime>(startDateAsJson);
        myObject.CurrentDate = (System.DateTime)JsonUtility.FromJson<JsonDateTime>(currentDateAsJson);
    }

    public static void FirstLoadGameDataNew(DataObject myObject)
    {

        string filePath = Application.dataPath + "/Data/Data.json";


        string dataAsJson = File.ReadAllText(filePath);

        JsonUtility.FromJsonOverwrite(dataAsJson, myObject);


    }

    public static void UpdateData(DataObject myObject)
    {
        myObject.TotalEXP = myObject.StrengthEXP + myObject.CharismaEXP +
            myObject.IntellectEXP;
        //TODO trigger event on level up
        myObject.PlayerLevel = myObject.TotalEXP / 100;
        myObject.StrengthLevel = myObject.StrengthEXP / 100;
        myObject.CharismaLevel = myObject.CharismaEXP / 100;
        myObject.IntellectLevel = myObject.IntellectEXP / 100;

        //Date and time stuff
        myObject.CurrentDate = System.DateTime.Now;
        myObject.DayCounter = System.Convert.ToInt32((myObject.CurrentDate - myObject.StartDate).TotalDays);
        if (myObject.DayCounter != myObject.LastDayPlayed)
        {
            Debug.Log("New Day");
            myObject.DailyQuestCounter = 0;
        }
        myObject.LastDayPlayed = System.Convert.ToInt32((myObject.CurrentDate - myObject.StartDate).TotalDays);




    }


}
