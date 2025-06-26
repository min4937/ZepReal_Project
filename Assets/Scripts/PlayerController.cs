using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestInputPlayer : MonoBehaviour, PlayerInputControls.IPlayerActions
{
    private PlayerInputControls inputControls;
    Rigidbody2D rigidbody2;
    private Vector2 moveDirection;
    public float MoveSpeed;

    void Awake()
    {
        inputControls = new PlayerInputControls();
        rigidbody2 = GetComponent<Rigidbody2D>();
    }

    void OnEnable()
    {
        inputControls.Player.SetCallbacks(this);
        inputControls.Enable();
    }

    void OnDisable()
    {
        inputControls.Disable();
    }

    void FixedUpdate()
    {
        rigidbody2.velocity = moveDirection * MoveSpeed;
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        moveDirection = context.ReadValue<Vector2>();
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }

    public void OnFire(InputAction.CallbackContext context)
    {
        throw new System.NotImplementedException();
    }
}