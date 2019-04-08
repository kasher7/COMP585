using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetGameData : MonoBehaviour
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
        myData.DailyProgress = new double[28];
        myData.TotalEXP = 0;
        myData.PlayerLevel = 0;
        myData.StrengthEXP = 0;
        myData.CharismaEXP = 0;
        myData.IntellectEXP = 0;
        myData.StrengthLevel = 0;
        myData.CharismaLevel = 0;
        myData.IntellectLevel = 0;
        myData.QuestAmountCompleted = 0;
        //Initialize first time playing trigger to true
        //make sure to change to false after intializing game
        myData.FirstTimePlaying = true;

        //Here We load the quest txt content
        //Currently we use only place holder text
        TextAsset myText = (TextAsset)Resources.Load("QuestText/test");
        string[] textArray = myText.text.Split('#');

        //Later we will set these to their specific quest lines
        myData.StrengthQuestLine = textArray;
        myData.IntellectQuestLine = textArray;
        myData.IntellectQuestLine = textArray;
        myData.FailureQuestLine = textArray;



        DataLogic.SaveGameData(myData);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
