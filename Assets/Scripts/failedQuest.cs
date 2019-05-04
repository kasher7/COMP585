using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class failedQuest : MonoBehaviour
{
    // public Text story;
    // Start is called before the first frame update
    public Text story;

    void Start()
    {   int expGained = questConstants.timeSpent * 10;
        DataObject myData = DataLogicNew.Load();
        if (myData.DayCounter == 27){
            // check for day 28 ie last day
            story.text = "You have completed the game but you didn't beat the final boss. Start a new character and try again";
        }else{
           if (questConstants.questType == "Strength"){
            story.text = myData.FailureQuestLine[myData.DayCounter];
            myData.StrengthEXP +=expGained;
            myData.DailyStrengthEXP[myData.DayCounter] += expGained;
        }else if (questConstants.questType == "Charisma"){
            story.text = myData.FailureQuestLine[myData.DayCounter];    
            myData.CharismaEXP +=expGained;
            myData.DailyCharismaEXP[myData.DayCounter] += expGained;
        } else if (questConstants.questType == "Intelligence"){
            story.text = myData.FailureQuestLine[myData.DayCounter]; 
            myData.IntellectEXP +=expGained;
            myData.DailyIntellectEXP[myData.DayCounter] += expGained;
        }
        }
        
        myData.DailyTotalEXP[myData.DayCounter] = myData.DailyStrengthEXP[myData.DayCounter] + 
            myData.DailyIntellectEXP[myData.DayCounter] + 
            myData.DailyCharismaEXP[myData.DayCounter];
        myData.QuestCompleteLog[myData.DayCounter*100 + myData.DailyQuestCounter] = false;
        myData.DailyQuestCounter += 1;
        DataLogicNew.Save(myData);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
