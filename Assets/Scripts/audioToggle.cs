using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioToggle : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onOff(){
        if (PlayerPrefs.GetInt("audio")==1){
            PlayerPrefs.SetInt("audio", 0);
        } else if (PlayerPrefs.GetInt("audio")==0){
            PlayerPrefs.SetInt("audio", 1);
        } else{
            PlayerPrefs.SetInt("audio", 0);
        }
        
    }
}
