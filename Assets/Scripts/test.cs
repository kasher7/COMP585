using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TextAsset myText = (TextAsset)Resources.Load("QuestText/test");
        string[] textArray = myText.text.Split('#');
        for (int i = 0; i<textArray.Length; i++)
        {
            Debug.Log(textArray[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
