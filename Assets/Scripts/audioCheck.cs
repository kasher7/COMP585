using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audioCheck : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource audio;
    void Start()
    {
        audio.playOnAwake = true;
        Debug.Log(PlayerPrefs.GetInt("audio"));
        if (PlayerPrefs.GetInt("audio")==1){
            audio.Play();
        } else if (PlayerPrefs.GetInt("audio")==0){
            audio.Stop();
        } else{
            audio.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
