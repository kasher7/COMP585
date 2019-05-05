using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getCharacterInfo : MonoBehaviour
{
    // Start is called before the first frame update
    public DataObject myData = new DataObject();

    public Text name;
    public Text lvl;

    public Text charisLvl;
    public Text strenLvl;
    public Text intelLvl;

    public Text totalTime;
    public Text charisTime;
    public Text strenTime;
    public Text intelTime;


    void Start()
    {
        myData = DataLogicNew.Load();
        name.text = "Name: " + myData.PlayerName;
        lvl.text = "Level: " + myData.PlayerLevel;
        charisLvl.text= "Charisma Level: " + myData.CharismaLevel;
        strenLvl.text = "Strength Level: " + myData.StrengthLevel;
        intelLvl.text = "Intellect Level: " + myData.IntellectLevel;
        totalTime.text = "Total time spent: " + (myData.TotalEXP/20).ToString() + "mins";
        charisTime.text= "Charisma time spent: " + (myData.CharismaEXP/20).ToString() + "mins";
        strenTime.text = "Strength time spent: " + (myData.StrengthEXP/20).ToString()+"mins";
        intelTime.text = "Intellect time spent: " + (myData.IntellectEXP/20).ToString()+"mins";


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
