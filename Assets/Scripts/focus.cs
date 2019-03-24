﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class focus : MonoBehaviour
{
    private bool focused = true;

    //public bool Focused { get => focused; set => focused = value; }

    // Start is called before the first frame update

    public Text text;
    public GameObject background;
    Image img;

    void Start()
    {
        img = background.GetComponent<Image>();
        img.color = Color.blue;
        text.text = "Focused";
        //background.backgroundColor = Color.blue;
        focused = Application.isFocused;
    }

    // Update is called once per frame
    void Update()
    {
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
            text.text = "Not Focused";
            img.color = Color.red;
            //Debug.Log("Out of Focus");
        }
        else
        {
            //Debug.Log("In Focus");
        }
    }
}
