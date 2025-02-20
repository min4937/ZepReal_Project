using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    private Animator animator;
    private bool isMoving = false;
    private string isMovingParameterName = "IsMove";
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool moveInput = Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0;

        // 이동 상태가 변경되었는지 확인
        if (moveInput != isMoving)
        {
            isMoving = moveInput; // 상태 업데이트
            animator.SetBool(isMovingParameterName, isMoving); // Animator 파라미터 업데이트
        }
    }
}
