using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataObject
{
    //General Data
    private int playerLevel;
    private string playerName;

    //Strength Data
    private float strengthQuestTime;


    //Getters and Setters
    public int PlayerLevel { get => playerLevel; set => playerLevel = value; }
    public string PlayerName { get => playerName; set => playerName = value; }
    public float StrengthQuestTime { get => strengthQuestTime; set => strengthQuestTime = value; }
}
