using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine
{
    public List<State> states = new List<State>();
    public State currentState;

    public void AddState(State state)
    {
        states.Add(state);
    }

    public void Update()
    {
        if (currentState != null)
        {
            currentState.Update();
        }
    }

    public void Enter()
    {
        if (currentState != null)
        {
            currentState.Exit();
        }

        currentState = states[0];
        currentState.Enter();
    }
}
