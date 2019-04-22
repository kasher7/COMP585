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
        name.text = " ";
        if (myData.FirstTimePlaying)
        {
            //TODO let user pick name
            myData.PlayerName = name.text;
            myData.QuestLength = 28;
            myData.StartDate = System.DateTime.Now;
            myData.CurrentDate = System.DateTime.Now;
            myData.DayCounter = System.Convert.ToInt32((myData.CurrentDate-myData.StartDate).TotalDays);
            myData.LastDayPlayed = System.Convert.ToInt32((myData.CurrentDate - myData.StartDate).TotalDays);
            Debug.Log("printing dates");
            Debug.Log(myData.CurrentDate);
            Debug.Log(myData.LastDayPlayed);
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
            myData.DailyStrengthEXP = new int[28];
            myData.DailyIntellectEXP = new int[28];
            myData.DailyTotalEXP = new int[28];
            Debug.Log("daily exp");
            Debug.Log(myData.DailyTotalEXP);
            // Array.Clear(myData.DailyTotalEXP,0,myData.DailyTotalEXP.Length);
            Debug.Log("clearing");
            Debug.Log(myData.DailyTotalEXP.Length);
            //Initialize first time playing trigger to true
            //make sure to change to false after intializing game

            //Here We load the quest txt content
            TextAsset preStrengthQuestLine = (TextAsset)Resources.Load("QuestText/StrengthQuestLinePre");
            TextAsset preIntellectQuestLine = (TextAsset)Resources.Load("QuestText/IntellectQuestLinePre");
            TextAsset preCharismaQuestLine = (TextAsset)Resources.Load("QuestText/CharismaQuestLinePre");
            TextAsset postStrengthQuestLine = (TextAsset)Resources.Load("QuestText/StrengthQuestLinePost");
            TextAsset postIntellectQuestLine = (TextAsset)Resources.Load("QuestText/IntellectQuestLinePost");
            TextAsset postCharismaQuestLine = (TextAsset)Resources.Load("QuestText/CharismaQuestLinePost");
            TextAsset postFailureQuestLine = (TextAsset)Resources.Load("QuestText/FailureQuestLinePost");

            myData.PreStrengthQuestLine = preStrengthQuestLine.text.Split('#');
            myData.PreCharismaQuestLine = preIntellectQuestLine.text.Split('#');
            myData.PreIntellectQuestLine = preCharismaQuestLine.text.Split('#');
            myData.PostStrengthQuestLine = postStrengthQuestLine.text.Split('#');
            myData.PostCharismaQuestLine = postIntellectQuestLine.text.Split('#');
            myData.PostIntellectQuestLine = postCharismaQuestLine.text.Split('#');
            myData.FailureQuestLine = postFailureQuestLine.text.Split('#');




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
