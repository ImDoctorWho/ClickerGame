using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Instrumental
{
    protected int _level;
    protected int _multipleMining;


    public virtual bool IsEnable(int i) => _level == i ? true : false; 
    public virtual int GetLevel() { return _level; }
    public virtual int GetMultiple() { return _multipleMining; }
    public virtual void AddLevel() { _level++; }
    public virtual void SetMultiple() { _multipleMining *= 2; }
}
