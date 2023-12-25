using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine<T> : IStateMachine where T : AbsState
{
    private Dictionary<Type, T> _states;
    private AbsState _currState;
    public StateMachine(T shootAttackState)
    {
        SetupStates(shootAttackState);
    }

    private void SetupStates(T shootAttackState)
    {
        _states = new()
        {
            { typeof(ShootAttackState), shootAttackState}
        };

        foreach (var state in _states)
        {
            state.Value.SetOwner(this);
        }
    }

    public bool ChangeState<T>()
    {
        _currState?.Exit();
        if (_states.ContainsKey(typeof(T)))
        {
            _currState = _states[typeof(T)];
            _currState.Enter();
            return true;
        }
        return false;
    }

    public void Update()
    {
        Debug.Log(_currState);
        _currState.Update();
    }
}

