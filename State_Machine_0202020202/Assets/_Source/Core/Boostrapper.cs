using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boostrapper : MonoBehaviour
{
    public List<State> states = new List<State>();
    public StateMachine stateMachine;

    private void Start()
    {
        State _attackState = new AttackState();
        State _redZoneState = new RedZoneState();
        State _ghostState = new GhostState();
        stateMachine = new StateMachine();
        stateMachine.AddState(_attackState);
        stateMachine.AddState(_redZoneState);
        stateMachine.AddState(_ghostState);
        stateMachine.currentState = stateMachine.states[0];
        stateMachine.currentState.Enter();
    }

    private void Update()
    {
        stateMachine.Update();
    }
}


