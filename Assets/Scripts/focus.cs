using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class focus : MonoBehaviour
{
    private bool focused = true;

    //public bool Focused { get => focused; set => focused = value; }

    // Start is called before the first frame update

    public Text text;
    public Text timerText;
    public GameObject background;
    float timeleft = 10.0f;
    Image img;

    void Start()
    {
        // img = background.GetComponent<Image>();
        // img.color = Color.blue;
        text.text = "In Quest";
        timerText.text = timeleft + " seconds left";

        focused = Application.isFocused;
        Screen.sleepTimeout = SleepTimeout.NeverSleep;
    }

    // Update is called once per frame
    void Update()
    {
        timeleft -= Time.deltaTime;
        if(timeleft <= 0)
        {
            //Load complete scene
        }
        timerText.text = (timeleft - timeleft%1) + " seconds left";
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
            text.text = "Quest Failed";
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
