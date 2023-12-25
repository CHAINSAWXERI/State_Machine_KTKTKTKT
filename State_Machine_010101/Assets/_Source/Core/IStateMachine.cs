using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IStateMachine
{
    bool ChangeState<T>();

    void Update();
}
