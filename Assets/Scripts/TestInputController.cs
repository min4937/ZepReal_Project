using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestInputController : MonoBehaviour, PlayerInputControls.IPlayerActions
{
    private PlayerInputControls input;
    private Rigidbody2D rigid;
    [SerializeField]
    private float moveSpeed;

    void Awake()
    {
        input = new PlayerInputControls();
        rigid = GetComponent<Rigidbody2D>();
    }

    void OnEnable()
    {
        input.Player.SetCallbacks(this);
        input.Enable();
    }

    void OnDisable()
    {
        input.Disable();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        if (rigid != null)
        {
            rigid.velocity = context.ReadValue<Vector2>() * moveSpeed;
        }
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