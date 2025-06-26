using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class PlayerController : BaseController
{
    private new Camera camera;
    private GameManager gameManager;

    public bool useFireAction = true;

    public void Init(GameManager gameManager)
    {
        this.gameManager = gameManager;
        camera = Camera.main;
    }

    protected override void HandleAction()
    {
        
    }
    public override void Death()
    {
        base.Death();
        if (gameManager != null)
        {
            gameManager.GameOver();
        }
    }

    void OnMove(InputValue inputValue)
    {
        movementDirection = inputValue.Get<Vector2>().normalized;
    }

    void OnLook(InputValue inputValue)
    {
        Vector2 mousePosition = inputValue.Get<Vector2>();
        Vector2 worldPos = camera.ScreenToWorldPoint(mousePosition);
        Vector2 newLookDirection = (worldPos - (Vector2)transform.position);

        if (newLookDirection.magnitude > 0.1f)
        {
            lookDirection = newLookDirection.normalized;
        }
    }

    void OnFire(InputValue inputValue)
    {
        if (useFireAction)
        {
            if (EventSystem.current.IsPointerOverGameObject())
                return;

            isAttacking = inputValue.isPressed;
        }
    }
}