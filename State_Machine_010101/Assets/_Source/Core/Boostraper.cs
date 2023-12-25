using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boostraper : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private InputListener _inputListener;
    private IStateMachine _playerStateMachine;

    private void Awake()
    {
        _inputListener.Construct(_playerMovement);
        _playerStateMachine = new StateMachine<AbsState>(new ShootAttackState());
    }

    private void Update()
    {
        _playerStateMachine.Update();
    }
}
