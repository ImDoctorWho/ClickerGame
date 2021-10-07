using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkshopBildings : Buildings
{
    public WorkshopBildings(string keyLevel, int defNum)
    {
        _key = keyLevel;
        _defaultData = defNum;
    }
}
