using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int test = 0;
        double currentDate = System.DateTime.Now.ToOADate();
        Debug.Log(currentDate);
        double[] test2 = new double[5];
        Debug.Log(test2[0]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
