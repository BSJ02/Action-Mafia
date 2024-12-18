using Unity.Netcode;
using UnityEngine;

public abstract class StateMachine : NetworkBehaviour
{
    private IState currentState = null;

    protected void Update()
    {
        currentState?.Update();
    }

    protected void ChangeState(IState state)
    {
        if (currentState != null && currentState.Equals(state)) return;

        currentState?.Exit();
        currentState = state;
        currentState.Enter();
    }
}