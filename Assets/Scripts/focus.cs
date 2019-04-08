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

    float timeLeftSec = questConstants.questTime * 60;

    void Start()
    {
        // img = background.GetComponent<Image>();
        // img.color = Color.blue;
        text.text = "In Quest";
        timerText.text = (timeLeftSec - timeLeftSec % 60)/60 + " minutes " + timeLeftSec % 60 + " seconds left";
        questTypes.text = "you are on a " + questConstants.questType + " quest!";
        focused = Application.isFocused;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeftSec -= Time.deltaTime;
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
        if (text.text == "Failed")
        {
            SceneManager.LoadScene("questFailed");
        }
    }

    void OnApplicationFocus(bool pauseStatus)
    {
        if (pauseStatus)
        {
            Debug.Log("in focus");
        }
        else
        {
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
            text.text = "In Quest";
            //Debug.Log("In Focus");
        }
    }
}