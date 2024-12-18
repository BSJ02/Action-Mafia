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

        // �̺�Ʈ �߰�
        InputActions.Player.AddCallbacks(this);

        // �Է��� ����
        InputActions.Player.Enable();
    }

    private void OnDisable()
    {
        // �̺�Ʈ ����
        InputActions.Player.RemoveCallbacks(this);

        // �Է��� �� ����
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