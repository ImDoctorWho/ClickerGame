using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeBuilding : Buildings
{
    public HomeBuilding(string keyLevel, int defNum)
    {
        _key = keyLevel;
        _defaultData = defNum;
    }
}
