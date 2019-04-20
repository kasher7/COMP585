﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class resetGameData : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField name = null;
    public DataObject myData = new DataObject();
    void Start()
    {
        if (myData.FirstTimePlaying)
        {
            //TODO let user pick name
            myData.PlayerName = "";
            myData.QuestLength = 28;
            myData.StartDate = System.DateTime.Now;
            myData.CurrentDate = System.DateTime.Now;
            myData.DayCounter = System.Convert.ToInt32((myData.CurrentDate - myData.StartDate).TotalDays);
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
        else
        {
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
        myData.FirstTimePlaying = false;
        SceneManager.LoadScene("menu");
    }



}
