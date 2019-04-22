using System.Collections;
using System.Collections.Generic;
using UnityEngine;

struct JsonDateTime
{
    public long value;
    public static implicit operator System.DateTime(JsonDateTime jdt)
    {
        Debug.Log("Converted to time");
        return System.DateTime.FromFileTimeUtc(jdt.value);
    }
    public static implicit operator JsonDateTime(System.DateTime dt)
    {
        Debug.Log("Converted to JDT");
        JsonDateTime jdt = new JsonDateTime();
        jdt.value = dt.ToFileTimeUtc();
        return jdt;
    }
}