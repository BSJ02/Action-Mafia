using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerStateMachine : StateMachine, InputSystem_Actions.IPlayerActions
{
    public InputSystem_Actions InputActions { get; private set; }

    private PlayerWalkState playerWalkState;

    private void OnEnable()
    {
        InputActions = new InputSystem_Actions();

        playerWalkState = new PlayerWalkState(this);

        // 이벤트 추가
        InputActions.Player.AddCallbacks(this);

        // 입력을 받음
        InputActions.Player.Enable();
    }

    private void OnDisable()
    {
        // 이벤트 제거
        InputActions.Player.RemoveCallbacks(this);

        // 입력을 안 받음
        InputActions.Player.Disable();
    }

    private new void Update()
    {
        if (!IsOwner || !IsSpawned) return;

        base.Update();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        ChangeState(playerWalkState);
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        
    }

    public void OnAttack(InputAction.CallbackContext context)
    {
        
    }

    public void OnInteract(InputAction.CallbackContext context)
    {
        
    }

    public void OnCrouch(InputAction.CallbackContext context)
    {
        
    }

    public void OnJump(InputAction.CallbackContext context)
    {
       
    }

    public void OnPrevious(InputAction.CallbackContext context)
    {
        
    }

    public void OnNext(InputAction.CallbackContext context)
    {
        
    }

    public void OnSprint(InputAction.CallbackContext context)
    {
        
    }
}