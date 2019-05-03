using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

//Data Manipulation order

public class DataLogic
{
    public static void SaveGameData(DataObject myObject)
    {
        UpdateGameData(myObject);
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
    public void Save(DataObject myObject)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/Data.dat");

        bf.Serialize(file, data);
        file.Close();
    }

    public void Load(DataObject myObject)
    {
        if (File.Exists(Application.persistentDataPath + "/Data.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/Data.dat", FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            score = data.score;
            levelcount = data.levelcount;
        }
    }

    public static void LoadGameData(DataObject myObject)
    {
        UpdateGameData(myObject);
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

    public static void FirstLoadGameData(DataObject myObject)
    {

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
