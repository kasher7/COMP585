using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class focus : MonoBehaviour
{
    private bool focused = true;

    //public bool Focused { get => focsused; set => focused = value; }

    // Start is called before the first frame update
    public Text questTypes;
    public Text text;
    public Text timerText;

    public GameObject background;
    float timeLeftSec = questConstants.questTime * 60;
    float timer;
    bool isSleep;

    int fingerCount;

    // data obj
    public DataObject myData = new DataObject();
    
    void Start()
    {
        myData = DataLogicNew.Load();
        text.text = "In Quest";
        if (text.text != "Failed"){
            // checks if he is worthy
            Debug.Log("daycounter " + myData.DayCounter);
            if(myData.DayCounter == 27){
                for (int i = 0; i< (myData.QuestCompleteLog.Length/100)-1; i++){
                    bool metReqirement = false;
                    for (int j =0; j< 100; j++){
                        if (myData.QuestCompleteLog[i*100+j]){
                            metReqirement = true;
                        }
                    }
                    if (!metReqirement){
                        text.text = "Failed";
                    }

                }
            }
            if (questConstants.questType == "Strength"){
                Debug.Log(myData.PreStrengthQuestLine.Length);
                questTypes.text = myData.PreStrengthQuestLine[myData.DayCounter];
            }else if (questConstants.questType == "Charisma"){
                questTypes.text = myData.PreCharismaQuestLine[myData.DayCounter];
            } else if (questConstants.questType == "Intelligence"){
                questTypes.text = myData.PreIntellectQuestLine[myData.DayCounter];
            }
        }else{
            Debug.Log("Failing text");
        }
        // setting up questing quates

        // img = background.GetComponent<Image>();
        // img.color = Color.blue;
        timerText.text = (timeLeftSec - timeLeftSec % 60)/60 + " minutes " + timeLeftSec % 60 + " seconds left";
        // questTypes.text = "you are on a " + questConstants.questType + " quest!";
        focused = Application.isFocused;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
        timer = 0;
        fingerCount = 0;
        isSleep = false;
        // text.text = "Failed";

    }

    // Update is called once per frame
    void Update()
    {   
        // time runs 100 times faster for testing reason
        // change this back later
        timeLeftSec -= Time.deltaTime;
        timer += Time.deltaTime;
        
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
            {
                fingerCount++;
            }
        }

        if (Input.GetMouseButtonDown(0) | fingerCount > 0){
            timer = 0f;
            fingerCount = 0;
        }
        if (timeLeftSec <= 0)
        {
            //Load complete scene
            SceneManager.LoadScene("questCompleted");

        }
        timerText.text = (timeLeftSec - timeLeftSec % 60)/60 + " minutes " + Mathf.Round((timeLeftSec % 60)) + " seconds left";
        focused = Application.isFocused;
        if (!focused)
        {
            //text.text = "Not Focused";
            //Debug.Log("Out of Focus");
        }
        else
        {
            //Debug.Log("In Focus");
        }
        // check timeout
        if(text.text == "In Quest" & timer > 10.0f){
            background.SetActive(true);
        }else{
            background.SetActive(false);
        }
        // check quest failed
        if (text.text == "Failed")
        {
            questConstants.timeSpent = questConstants.questTime - (int)((timeLeftSec - timeLeftSec % 60)/60);
            SceneManager.LoadScene("questFailed");
        }
    }

    void OnApplicationFocus(bool pauseStatus)
    {
        if (pauseStatus)
        {
            text.text = "In Quest";
            // text.text = "Failed";
            Debug.Log("in focus");
        }
        else
        {
            text.text = "Failed";
            // text.text = "In Quest";
            Debug.Log("out of focus");
        }
    }

    void OnApplicationPause(bool pauseStatus)
    {
        if (pauseStatus)
        {
            text.text = "Failed";

            // img.color = Color.red;
            //Debug.Log("Out of Focus");
        }
        else
        {
            text.text = "Failed";
            //Debug.Log("In Focus");
        }
    }
}