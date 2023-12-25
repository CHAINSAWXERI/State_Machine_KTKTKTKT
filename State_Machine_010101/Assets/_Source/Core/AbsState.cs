using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbsState 
{
    protected IStateMachine _owner;

    public void SetOwner(IStateMachine owner)
    {
        _owner = owner;
    }

    public virtual void Enter() { }
    public virtual void Update() { }
    public virtual void Exit() { }
}