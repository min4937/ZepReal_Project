using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour, PlayerInputControls.IPlayerActions
{
    private PlayerInputControls input;
    private Rigidbody2D rigid;
    [SerializeField]    
    private float moveSpeed;

    public void OnMove(InputAction.CallbackContext context)
    {
        rigid.velocity = context.ReadValue<Vector2>() * moveSpeed;
    }

    // Start is called before the first frame update
    void Start()
    {
        input = new();
        input.Player.SetCallbacks(this);
        input.Enable();        
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
