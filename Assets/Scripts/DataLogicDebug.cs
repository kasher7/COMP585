using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataLogicDebug : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DataObject myObject = new DataObject();
        DataLogic.LoadGameData(myObject);
        myObject.PlayerLevel = 55;
        myObject.FirstTimePlaying = true;
        DataLogic.SaveGameData(myObject);
        DataObject myNewObject = new DataObject();
        DataLogic.LoadGameData(myNewObject);
        Debug.Log(myNewObject.PlayerLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
