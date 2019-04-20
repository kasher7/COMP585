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
    /*
     NOTE: All Dates are stored as string arrays ordered as follows:
     -[0] Month (string number)
     -[1] Day (string number)
     -[2] Year (string number)
     -[3] Hour (string number)
     -[4] Minute (string number)
     -[5] Second (string number)
     -[6] Period (string "am" or "pm")
     */


    [SerializeField]
    private string[] startDate;
    [SerializeField]
    private string[] currentDate;
    [SerializeField]
    private double[] dailyProgress;
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
    public string[] StartDate { get => startDate; set => startDate = value; }
    public string[] CurrentDate { get => currentDate; set => currentDate = value; }
    public double[] DailyProgress { get => dailyProgress; set => dailyProgress = value; }
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
    public string[] StrengthQuestLine { get => strengthQuestLine; set => strengthQuestLine = value; }
    public string[] CharismaQuestLine { get => charismaQuestLine; set => charismaQuestLine = value; }
    public string[] IntellectQuestLine { get => intellectQuestLine; set => intellectQuestLine = value; }
    public string[] FailureQuestLine { get => failureQuestLine; set => failureQuestLine = value; }
    public string[] LastDayPlayed { get => lastDayPlayed; set => lastDayPlayed = value; }
}
