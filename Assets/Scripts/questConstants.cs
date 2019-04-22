using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class questConstants
{
    public static int questTime;
    public static string questType;

    public static string charClass;

    public static int timeSpent;

    public static void setQuestTime(int value){
        questTime = value;
    }

    public static void setQuestType(string value){
        questType = value;
    }

    public static void setCharClass(string value){
        charClass = value;
    }

    public static void setTimeSpent(int value){
        timeSpent = value;
    }


}
