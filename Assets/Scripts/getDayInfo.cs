using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getDayInfo : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        for (int i =0; i< GameObject.FindGameObjectsWithTag("calender").Length ; i++){
            Debug.Log(GameObject.FindGameObjectsWithTag("calender")[i].GetComponentInChildren<Text>().text);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
