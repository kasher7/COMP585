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
    private int questLength;
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
}
