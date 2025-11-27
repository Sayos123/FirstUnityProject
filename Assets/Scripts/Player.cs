using System.Threading;
using UnityEditor.Rendering.LookDev;
using UnityEngine;
using UnityEngine.InputSystem;
public class Player : MonoBehaviour
{
    [SerializeField]
    float speed = 10;

    [SerializeField]
    private CharacterController controller;

    private void Update()
    {
        controller.Move(lastMovementInput * Time.deltaTime);
    }

    private Vector2 lastMovementInput;
    public void MovementInput(InputAction.CallbackContext context)
    {
        lastMovementInput = context.ReadValue<Vector2>();
        Debug.Log("anything");
    }

   
}
