using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pick : Instrumental
{
    public Pick(string key, int defNum)
    {
        _key = key;
        _defaultData = defNum;
    }
}
