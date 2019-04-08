using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class initializeGameData : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DataObject myData = new DataObject();
        myData.PlayerName = "John Smith";
        myData.QuestLength = 30;
        myData.DayCounter = 0;
        myData.StartDate = System.DateTime.Now.ToOADate();
        myData.CurrentDate = System.DateTime.Now.ToOADate();
        //TODO I'm just assuming these arrays initialize to all zeros...If not we'll probably find out later
        myData.DailyProgress = new double[30];
        myData.TotalEXP = 0;
        myData.PlayerLevel = 0;
        myData.StrengthEXP = 0;
        myData.CharismaEXP = 0;
        myData.IntellectEXP = 0;


        DataLogic.SaveGameData(myData);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
