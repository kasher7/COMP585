﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class goToFocus : MonoBehaviour
{
    public Dropdown dropDown;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void goQuest(){
        int time = dropDown.value * 10 + 30;
        Debug.Log("Time: " + time);
        SceneManager.LoadScene("questMain");

    }

}
