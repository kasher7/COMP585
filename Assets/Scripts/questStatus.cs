using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class questStatus : MonoBehaviour
{   
    
    public Text type;
    public Text time;

    public Text exp;

    public Text status;

    public Text story;
    // Start is called before the first frame update

    
    void Start()
    {   
        int expGained = questConstants.questTime * 20;
        type.text = "Quest Type: " + questConstants.questType;
        time.text = "Time Spent: " + questConstants.questTime;
        exp.text =  "Exp gained: " + expGained;
        //Data update logic
        DataObject myData = new DataObject();
        DataLogic.LoadGameData(myData);
        if (questConstants.questType == "Strength"){
            myData.StrengthEXP +=expGained;
            myData.TotalEXP += expGained;
            myData.DailyStrengthEXP[myData.DayCounter] += expGained;
            story.text = myData.PostStrengthQuestLine[myData.DayCounter];
        }else if (questConstants.questType == "Charisma"){
            myData.CharismaEXP +=expGained;
            myData.TotalEXP += expGained;
            myData.DailyCharismaEXP[myData.DayCounter] += expGained;
            story.text = myData.PostCharismaQuestLine[myData.DayCounter];    
        } else if (questConstants.questType == "Intelligence"){
            myData.IntellectEXP +=expGained;
            myData.TotalEXP += expGained;
            myData.DailyIntellectEXP[myData.DayCounter] += expGained;
            story.text = myData.PostIntellectQuestLine[myData.DayCounter];
        }
        //Dont go over the max index length
        //it a temp solution
        myData.QuestCompleteLog[myData.DayCounter*100 + myData.DailyQuestCounter] = true;
        myData.DailyQuestCounter += 1;
        Debug.Log(myData.QuestCompleteLog);
        DataLogic.SaveGameData(myData);
        status.text = "Quest completed";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


