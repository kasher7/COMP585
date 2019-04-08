using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class questStatus : MonoBehaviour
{   
    
    public Text type;
    public Text time;

    public Text status;
    // Start is called before the first frame update
    void Start()
    {
        type.text = "Quest Type: " + questConstants.questType;
        time.text = "Time Spent: " + questConstants.questTime;
        status.text = "Quest completed";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
