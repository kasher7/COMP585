using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataLogicDebug : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DataObject myObject = DataLogicNew.Load();
        myObject.PlayerLevel = 55;
        myObject.FirstTimePlaying = true;
        DataLogicNew.Save(myObject);
        DataObject myNewObject = DataLogicNew.Load();
        Debug.Log(myNewObject.PlayerLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
