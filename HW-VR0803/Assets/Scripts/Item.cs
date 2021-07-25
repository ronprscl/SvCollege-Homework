using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    string name;
    bool isOn;
    string additionalInfo;
    public Item(string name, bool isOn, string additionalInfo)
    {
        this.name = name;
        this.isOn = isOn;
        this.additionalInfo = additionalInfo;
    }
}
