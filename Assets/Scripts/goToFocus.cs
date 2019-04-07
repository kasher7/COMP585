using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class goToFocus : MonoBehaviour
{
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void goQuest(){
        print(GameObject.FindGameObjectsWithTag("timeDropdown")[0]);
        
        SceneManager.LoadScene("FocusTestScene");
    }

}
