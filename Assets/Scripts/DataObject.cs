﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class DataObject
{
    //General Data
    //Need to serialize private field so it can be converted to json
    [SerializeField]
    private string playerName;
    [SerializeField]
    private int questLength; //total quest length in minutes
    [SerializeField]
    private int dayCounter;
    [SerializeField]
    private int lastDayPlayed;


    [SerializeField]
    private System.DateTime startDate;
    [SerializeField]
    private System.DateTime currentDate;
    [SerializeField]
    private int[] dailyCharismaEXP;
    [SerializeField]
    private int[] dailyStrengthEXP;
    [SerializeField]
    private int[] dailyIntellectEXP;
    [SerializeField]
    private int[] dailyTotalEXP;
    [SerializeField]
    private int totalEXP;
    [SerializeField]
    private int playerLevel;
    [SerializeField]
    private int strengthEXP;
    [SerializeField]
    private int charismaEXP;
    [SerializeField]
    private int intellectEXP;
    [SerializeField]
    private int strengthLevel;
    [SerializeField]
    private int charismaLevel;
    [SerializeField]
    private int intellectLevel;
    [SerializeField]
    private double questAmountCompleted; //This should be equal to quest length if quest completed
    [SerializeField]
    private bool[] questCompleteLog;
    [SerializeField]
    private int dailyQuestCounter;

    //Main Trigger for first game startup
    [SerializeField]
    private bool firstTimePlaying = true;

    //Questlines (only differ by every 7th day)
    [SerializeField]
    private string[] preStrengthQuestLine;
    [SerializeField]
    private string[] preCharismaQuestLine;
    [SerializeField]
    private string[] preIntellectQuestLine;
    [SerializeField]
    private string[] postStrengthQuestLine;
    [SerializeField]
    private string[] postCharismaQuestLine;
    [SerializeField]
    private string[] postIntellectQuestLine;
    [SerializeField]
    private string[] failureQuestLine;





    //Getters and Setters
    public string PlayerName { get => playerName; set => playerName = value; }
    public int QuestLength { get => questLength; set => questLength = value; }
    public int DayCounter { get => dayCounter; set => dayCounter = value; }
    public System.DateTime StartDate { get => startDate; set => startDate = value; }
    public System.DateTime CurrentDate { get => currentDate; set => currentDate = value; }
    public int TotalEXP { get => totalEXP; set => totalEXP = value; }
    public int PlayerLevel { get => playerLevel; set => playerLevel = value; }
    public int StrengthEXP { get => strengthEXP; set => strengthEXP = value; }
    public int CharismaEXP { get => charismaEXP; set => charismaEXP = value; }
    public int IntellectEXP { get => intellectEXP; set => intellectEXP = value; }
    public int StrengthLevel { get => strengthLevel; set => strengthLevel = value; }
    public int CharismaLevel { get => charismaLevel; set => charismaLevel = value; }
    public int IntellectLevel { get => intellectLevel; set => intellectLevel = value; }
    public double QuestAmountCompleted { get => questAmountCompleted; set => questAmountCompleted = value; }
    public bool FirstTimePlaying { get => firstTimePlaying; set => firstTimePlaying = value; }
  
    public string[] FailureQuestLine { get => failureQuestLine; set => failureQuestLine = value; }
    public bool[] QuestCompleteLog { get => questCompleteLog; set => questCompleteLog = value; }
    public int[] DailyCharismaEXP { get => dailyCharismaEXP; set => dailyCharismaEXP = value; }
    public int[] DailyStrengthEXP { get => dailyStrengthEXP; set => dailyStrengthEXP = value; }
    public int[] DailyIntellectEXP { get => dailyIntellectEXP; set => dailyIntellectEXP = value; }
    public int[] DailyTotalEXP { get => dailyTotalEXP; set => dailyTotalEXP = value; }
    public int DailyQuestCounter { get => dailyQuestCounter; set => dailyQuestCounter = value; }
    public int LastDayPlayed { get => lastDayPlayed; set => lastDayPlayed = value; }
    public string[] PreStrengthQuestLine { get => preStrengthQuestLine; set => preStrengthQuestLine = value; }
    public string[] PreCharismaQuestLine { get => preCharismaQuestLine; set => preCharismaQuestLine = value; }
    public string[] PreIntellectQuestLine { get => preIntellectQuestLine; set => preIntellectQuestLine = value; }
    public string[] PostStrengthQuestLine { get => postStrengthQuestLine; set => postStrengthQuestLine = value; }
    public string[] PostCharismaQuestLine { get => postCharismaQuestLine; set => postCharismaQuestLine = value; }
    public string[] PostIntellectQuestLine { get => postIntellectQuestLine; set => postIntellectQuestLine = value; }
}
