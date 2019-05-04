using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getDayInfo : MonoBehaviour
{

    // Start is called before the first frame update
    private GameObject[] dayButtons;
    public Text info;
    public Text stats;
    public DataObject myData = new DataObject();

    void Start()
    {
        myData = DataLogicNew.Load();
        dayButtons = GameObject.FindGameObjectsWithTag("calender");
        // for some reason it mal functions on Android
        // for (int i =0; i< dayButtons.Length ; i++){
        //     // int capturedIterator = i;
        //     // Debug.Log(dayButtons[i].GetComponentInChildren<Text>().text);
        //     dayButtons[i].GetComponent<Button>().onClick.AddListener(() => dayClicked(i));
        // }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void dayClicked(int dayN){
        int sum = 0;
        for (int i = dayN*100; i < dayN*100+100; i++){
            if(myData.QuestCompleteLog[i]){
                sum += 1;
            }
        }
        info.text = "On day " + (dayN+1) + " you spent " + (myData.DailyTotalEXP[dayN]/PlayerPrefs.GetInt("difficulty")).ToString() + " mins doing quest. You've completed " + sum+ " quests on this day. ";
        if ((dayN == 27)&&(sum>=1)){
            stats.text = "You beat the game on this day.";
        }else{
            stats.text = "Types \n" + (myData.DailyCharismaEXP[dayN]/PlayerPrefs.GetInt("difficulty")).ToString() + " mins in charisma \n" + (myData.DailyIntellectEXP[dayN]/PlayerPrefs.GetInt("difficulty")).ToString() + " mins in intellect \n" + (myData.DailyStrengthEXP[dayN]/PlayerPrefs.GetInt("difficulty")).ToString() + " mins in strength";
        }
    }
}
