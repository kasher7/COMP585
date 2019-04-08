using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DataObject
{
    //General Data
    //Need to serialize private field so it can be converted to json
    [SerializeField]
    private int playerLevel;
    [SerializeField]
    private string playerName;

    //Strength Data
    [SerializeField]
    private float strengthQuestTime;


    //Getters and Setters
    public int PlayerLevel { get => playerLevel; set => playerLevel = value; }
    public string PlayerName { get => playerName; set => playerName = value; }
    public float StrengthQuestTime { get => strengthQuestTime; set => strengthQuestTime = value; }

    public void DisplayData()
    {
        Debug.Log("Player Level: " + playerLevel);
    }

}
