using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Instrumental
{
    protected int _level;
    protected int _multipleMining;
    protected string _key;
    protected int _defaultData;


    public virtual bool IsEnable(int i) => _level == i ? true : false; 
    public virtual int GetLevel() { return _level; }
    public virtual int GetMultiple() { return _multipleMining; }
    public virtual void AddLevel() { _level++; }
    public virtual void GetData() 
    {
        _level = PlayerPrefs.GetInt(_key, _defaultData);
        _multipleMining = _level * _level ;
    }
    public virtual void SetData() 
    {
        PlayerPrefs.SetInt(_key, _level);
    }
}
