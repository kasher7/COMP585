using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class newCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    public DataObject myData = new DataObject();
    
    void Start()
    {
        // myData.DayCounter = 0;
        // myData.LastDayPlayed = 0;
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void resetGame()
    {
        myData.FirstTimePlaying = true;
        DataLogic.SaveGameData(myData);
    }



}
