//ATTENTION, DONT FUCKING RUN THIS SCRIPT!!! IT WILL FUCK UP THE GAME DATA
//THIS IS ONLY EXAMPLE CODE SO THAT YOU KNOW HOW TO TO USE MY DATA API
//In fact I'm just gonna go ahead and comment all this shit out.



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataUpdateSample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        //Instantiate empty data object to use in script
        DataObject myData = new DataObject();
        //You MUST first load the existing game data, otherwise
        //you will overwrite all existing game data.
        DataLogic.LoadGameData(myData);
        //Now you can update the game data using the predefined
        //getters and setters (in DataObject class)
        myData.PlayerLevel = 8; // <--- Example
        myData.PlayerName = "Big Boii"; //<--- Example
        Debug.Log(myData.PlayerLevel);
        //After updating the DataObject you can now save it
        //To the json
        DataLogic.SaveGameData(myData);


        //To retrieve game data after loading you just type the same thing
        //you would as with the setters
        Debug.Log(myData.PlayerName);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
