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

        // �̵� ���°� ����Ǿ����� Ȯ��
        if (moveInput != isMoving)
        {
            isMoving = moveInput; // ���� ������Ʈ
            animator.SetBool(isMovingParameterName, isMoving); // Animator �Ķ���� ������Ʈ
        }
    }
}
