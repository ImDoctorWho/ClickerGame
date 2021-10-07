using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axe : Instrumental
{
    public Axe(string key, int defLevel)
    {
        _key = key;
        _defaultData = defLevel;
    }
}
