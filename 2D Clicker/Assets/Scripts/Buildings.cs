using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Buildings
{
    protected int _level;
    protected string _key;
    protected int _defaultData;

    public virtual int GetLevel() { return _level; }
    public virtual void AddLevel() { _level++; }

    public virtual void GetData()
    {
        _level = PlayerPrefs.GetInt(_key, _defaultData);
    }
    public virtual void SetData()
    {
        PlayerPrefs.SetInt(_key, _level);
    }

}
