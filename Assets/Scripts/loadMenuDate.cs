using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loadMenuDate : MonoBehaviour
{
    // Start is called before the first frame update
    private DataObject myData = new DataObject();
    void Start()
    {
        DataLogic.LoadGameData(myData);
        Debug.Log("print Date");
        Debug.Log(myData.CurrentDate);
        Debug.Log(myData.StartDate);
        DataLogic.SaveGameData(myData);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
