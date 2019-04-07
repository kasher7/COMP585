using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class questConstants
{
    public static int questTime;
    public static string questType;

    public static string charClass;

    public static void getQuestTime(int value){
        questTime = value;
    }

    public static void getQuestType(string value){
        questType = value;
    }

    public static void getCharClass(string value){
        charClass = value;
    }


}
