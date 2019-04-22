using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getDayInfo : MonoBehaviour
{

    // Start is called before the first frame update
    private GameObject[] dayButtons;
    public Text info;
    void Start()
    {
        dayButtons = GameObject.FindGameObjectsWithTag("calender");
        for (int i =0; i< dayButtons.Length ; i++){
            // Debug.Log(dayButtons[i].GetComponentInChildren<Text>().text);
            dayButtons[i].GetComponent<Button>().onClick.AddListener(delegate {dayClicked(i+1); });
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void dayClicked(int dayN){
        info.text = "this day "+ dayN + " is clicked";
    }
}
