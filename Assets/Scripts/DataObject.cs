using System.Collections;
using System.Collections.Generic;
using UnityEngine;


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
    private double startDate;
    [SerializeField]
    private double currentDate;
    [SerializeField]
    private double[] dailyProgress;
    [SerializeField]
    private double totalEXP;
    [SerializeField]
    private int playerLevel;
    [SerializeField]
    private double strengthEXP;
    [SerializeField]
    private double charismaEXP;
    [SerializeField]
    private double intellectEXP;
    [SerializeField]
    private int strengthLevel;
    [SerializeField]
    private int charismaLevel;
    [SerializeField]
    private int intellectLevel;
    [SerializeField]
    private double questAmountCompleted; //This should be equal to quest length if quest completed

    //Main Trigger for first game startup
    [SerializeField]
    private bool firstTimePlaying;

    //Questlines (only differ by every 7th day)
    [SerializeField]
    private string[] strengthQuestLine;
    [SerializeField]
    private string[] charismaQuestLine;
    [SerializeField]
    private string[] intellectQuestLine;
    [SerializeField]
    private string[] failureQuestLine;





    //Getters and Setters
    public string PlayerName { get => playerName; set => playerName = value; }
    public int QuestLength { get => questLength; set => questLength = value; }
    public int DayCounter { get => dayCounter; set => dayCounter = value; }
    public double StartDate { get => startDate; set => startDate = value; }
    public double CurrentDate { get => currentDate; set => currentDate = value; }
    public double[] DailyProgress { get => dailyProgress; set => dailyProgress = value; }
    public double TotalEXP { get => totalEXP; set => totalEXP = value; }
    public int PlayerLevel { get => playerLevel; set => playerLevel = value; }
    public double StrengthEXP { get => strengthEXP; set => strengthEXP = value; }
    public double CharismaEXP { get => charismaEXP; set => charismaEXP = value; }
    public double IntellectEXP { get => intellectEXP; set => intellectEXP = value; }
    public int StrengthLevel { get => strengthLevel; set => strengthLevel = value; }
    public int CharismaLevel { get => charismaLevel; set => charismaLevel = value; }
    public int IntellectLevel { get => intellectLevel; set => intellectLevel = value; }
    public double QuestAmountCompleted { get => questAmountCompleted; set => questAmountCompleted = value; }
    public bool FirstTimePlaying { get => firstTimePlaying; set => firstTimePlaying = value; }
    public string[] StrengthQuestLine { get => strengthQuestLine; set => strengthQuestLine = value; }
    public string[] CharismaQuestLine { get => charismaQuestLine; set => charismaQuestLine = value; }
    public string[] IntellectQuestLine { get => intellectQuestLine; set => intellectQuestLine = value; }
    public string[] FailureQuestLine { get => failureQuestLine; set => failureQuestLine = value; }
}
