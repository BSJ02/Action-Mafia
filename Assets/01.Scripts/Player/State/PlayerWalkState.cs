using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWalkState : IState
{
    public PlayerWalkState(PlayerStateMachine stateMachine)
    {
        inputAction = stateMachine.InputActions;
        characterController = stateMachine.GetComponent<CharacterController>();
        animator = stateMachine.GetComponent<Animator>();
    }

    private InputSystem_Actions inputAction;
    private CharacterController characterController;
    private Animator animator;

    public void Enter()
    {
        Debug.Log("move in");
    }

    public void Update()
    {
        Vector2 inputVector = inputAction.Player.Move.ReadValue<Vector2>();

        Vector3 direction = new Vector3(inputVector.x, 0, inputVector.y).normalized;

        characterController.Move(direction * 5 * Time.deltaTime);

        Quaternion targetRotation = Quaternion.LookRotation(direction);
        characterController.transform.rotation = Quaternion.Slerp(characterController.transform.rotation, targetRotation, Time.deltaTime * 30f);
    }

    public void Exit()
    {
        Debug.Log("move out");
    }
}
