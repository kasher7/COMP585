using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class resetGameData : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField name;
    public DataObject myData = new DataObject();
     
    
    void Start()
    {
        DataLogic.LoadGameData(myData);
        Debug.Log(myData.FirstTimePlaying);
        name.text = "Enter name here...";
        if (myData.FirstTimePlaying)
        {
            //TODO let user pick name
            myData.PlayerName = name.text;
            myData.QuestLength = 28;
            myData.StartDate = System.DateTime.Now;
            myData.CurrentDate = System.DateTime.Now;
            myData.DayCounter = System.Convert.ToInt32((myData.CurrentDate - myData.StartDate).TotalDays);
            myData.LastDayPlayed = System.Convert.ToInt32((myData.CurrentDate - myData.StartDate).TotalDays);
            //TODO I'm just assuming these arrays initialize to all zeros...If not we'll probably find out later
            myData.TotalEXP = 0;
            myData.PlayerLevel = 0;
            myData.StrengthEXP = 0;
            myData.CharismaEXP = 0;
            myData.IntellectEXP = 0;
            myData.StrengthLevel = 0;
            myData.CharismaLevel = 0;
            myData.IntellectLevel = 0;
            myData.QuestAmountCompleted = 0;

            //initialize everything in questcompletelog to false
            myData.QuestCompleteLog = new bool[2800];
            //TODO gross, but I had to hardcode in the number for this, should
            //fix so is always equal to first dimension of quest complete log later
            for (int i = 0; i< myData.QuestCompleteLog.Length; i++)
            {
                myData.QuestCompleteLog[i] = false;
            }
            myData.DailyQuestCounter = 0;

           
            Debug.Log("quest log");
            Debug.Log(myData.QuestCompleteLog);

            //TODO initialize all to zero?
            myData.DailyCharismaEXP = new int[28];
            Array.Clear(myData.DailyCharismaEXP,0,myData.DailyCharismaEXP.Length);
            myData.DailyStrengthEXP = new int[28];
            Array.Clear(myData.DailyStrengthEXP,0,myData.DailyStrengthEXP.Length);
            myData.DailyIntellectEXP = new int[28];
            Array.Clear(myData.DailyIntellectEXP,0,myData.DailyIntellectEXP.Length);
            myData.DailyTotalEXP = new int[28];
            Array.Clear(myData.DailyTotalEXP,0,myData.DailyTotalEXP.Length);
            //Initialize first time playing trigger to true
            //make sure to change to false after intializing game

            //Here We load the quest txt content
            //Currently we use only place holder text
            TextAsset myText = (TextAsset)Resources.Load("QuestText/test");
            string[] textArray = myText.text.Split('#');

            //Later we will set these to their specific quest lines
            myData.StrengthQuestLine = textArray;
            myData.IntellectQuestLine = textArray;
            myData.IntellectQuestLine = textArray;
            myData.FailureQuestLine = textArray;



            
        }
        else
        {
            Debug.Log("loading");
            SceneManager.LoadScene("menu");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void submit()
    {
        myData.PlayerName = name.text;
        Debug.Log(name.text);
        myData.FirstTimePlaying = false;
        DataLogic.SaveGameData(myData);
        SceneManager.LoadScene("menu");
    }

    public void resetGame()
    {
        myData.FirstTimePlaying = true;
    }



}
