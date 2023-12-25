using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputListener : MonoBehaviour
{
    private const string horizontalInput = "Horizontal";
    private const string verticalInput = "vertical";
    private PlayerMovement _playerMovement;

    public void Construct(PlayerMovement playerMovement)
    {
        _playerMovement = playerMovement;
    }
    private void Update()
    {
        ReadMovementInput();
    }

    private void ReadMovementInput()
    {
        if (_playerMovement != null)
        {
            _playerMovement.Move();
        }
    }
}
