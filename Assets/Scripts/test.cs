using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(System.DateTime.Now.ToString());
        string[] dateInfo = System.DateTime.Now.ToString().Split('/',' ',':');
        for(int i = 0; i< dateInfo.Length; i++)
        {
            Debug.Log(dateInfo[i]);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
