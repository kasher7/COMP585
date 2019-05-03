using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

//Data Manipulation order

public class DataLogicNew
{
    
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
            // UpdateData(data);
            file.Close();

            return data;
        }else{
            FileStream file = File.Create(Application.persistentDataPath + "/Data.dat");
            DataObject data = new DataObject();
            // UpdateData(data);
            return data;
        }
    }

    public static DataObject FirstLoad(){
        if (File.Exists(Application.persistentDataPath + "/Data.dat"))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(Application.persistentDataPath + "/Data.dat", FileMode.Open);
            DataObject data = (DataObject)bf.Deserialize(file);
            UpdateData(data);
            file.Close();

            return data;
        }else{
            FileStream file = File.Create(Application.persistentDataPath + "/Data.dat");
            DataObject data = new DataObject();
            UpdateData(data);
            return data;
        }
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
        myObject.CurrentDate = System.DateTime.Now.ToString();
        myObject.DayCounter = System.Convert.ToInt32((System.DateTime.Parse(myObject.CurrentDate) - System.DateTime.Parse(myObject.StartDate)).TotalDays);
        if (myObject.DayCounter != myObject.LastDayPlayed)
        {
            Debug.Log("New Day");
            myObject.DailyQuestCounter = 0;
        }
        myObject.LastDayPlayed = System.Convert.ToInt32((System.DateTime.Parse(myObject.CurrentDate) - System.DateTime.Parse(myObject.StartDate)).TotalDays);




    }


}
