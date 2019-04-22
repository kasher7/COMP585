using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getDayInfo : MonoBehaviour
{

    // Start is called before the first frame update
    private GameObject[] dayButtons;
    public Text info;
    public DataObject myData = new DataObject();

    void Start()
    {
        DataLogic.LoadGameData(myData);
        dayButtons = GameObject.FindGameObjectsWithTag("calender");
        for (int i =0; i< dayButtons.Length ; i++){
            int capturedIterator = i;
            // Debug.Log(dayButtons[i].GetComponentInChildren<Text>().text);
            dayButtons[i].GetComponent<Button>().onClick.AddListener(() => dayClicked(capturedIterator));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void dayClicked(int dayN){
        
        info.text = "On day " + dayN + " you spent " + (myData.DailyTotalEXP[dayN]/20).ToString() + " mins doing quest. " + (myData.DailyCharismaEXP[dayN]/20).ToString() + " mins in charisma " + (myData.DailyIntellectEXP[dayN]/20).ToString() + " mins in intellect " + (myData.DailyStrengthEXP[dayN]/20).ToString() + " mins in strength.";
    }
}
